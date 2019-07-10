using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("Unidad")]
    public class UnidadModel : AuditoriaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdAsignatura { get; set; }
        [ForeignKey("IdAsignatura")]
        public virtual AsignaturaModel Asignaturas { get; set; }
        public virtual ICollection<SilaboFaseUnidadModel> SilaboFaseUnidades { get; set; }
        public UnidadModel()
        {
            SilaboFaseUnidades = new HashSet<SilaboFaseUnidadModel>();
        }


        //public void SortList(Unidad unidadTem)
        //{
        //    Unidades.Sort(delegate (UnidadCurso a, UnidadCurso b)
        //    {
        //        int xdiff = a.Id.CompareTo(b.Id);
        //        if (xdiff != 0) return xdiff;
        //        else return a.SubUnidad.CompareTo(b.SubUnidad);
        //    });
        //}
    }
}