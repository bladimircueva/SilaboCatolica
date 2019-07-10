using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("UnidadCurso")]
    public class UnidadCursoModel : AuditoriaModel
    {
        private int id;
        private int subUnidad;
        private string descripcion;

        public UnidadCursoModel(int id, int subUnidad, string descripcion)
        {
            this.id = id;
            this.subUnidad = subUnidad;
            this.descripcion = descripcion;
        }

        public int SubUnidad { get => subUnidad; set => subUnidad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id { get => id; set => id = value; }
    }
}