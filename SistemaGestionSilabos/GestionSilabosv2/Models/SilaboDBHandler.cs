
using GestionSilabos.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    public class SilaboDBHandler
    {
        public List<SilaboHelper> ListarSilabos()
        {
            List<SilaboHelper> silabos = new List<SilaboHelper>();
            try
            {
                //using (SilabosDBContext context = new SilabosDBContext())
                //{
                //    silabos = context.Silabo.Include("").ToList().ForEach(s=> {
                //        new SilaboHelper() {
                //            Curso=s.Asignaturas.
                //        }
                //    });
                //}
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["SilaboDBContext"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("dbo.SP_Listar_Silabos", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@Par", SqlDbType.Int).Value = 1;
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            silabos.Add(new SilaboHelper()
                            {
                                Id = Convert.ToInt16(reader["Id"]),
                                Curso = reader["Curso"].ToString(),
                                Docente = reader["Docente"].ToString(),
                                Escuela = reader["Escuela"].ToString(),
                                Estado = reader["Estado"].ToString(),
                                Semestre = reader["Semestre"].ToString()
                            });

                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return silabos;
        }
    }
}