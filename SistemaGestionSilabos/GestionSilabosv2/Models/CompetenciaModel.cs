using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("Competencia")]
    public class CompetenciaModel:AuditoriaModel
    {
        public int Id { get; set; }
        public int IdEscuelas {get; set;}
        [ForeignKey("IdEscuelas")]
        public virtual EscuelaModel Escuela { get; set; }
        public String Descripcion { get; set; }
        public CompetenciaModel()
        {
            this.Escuela = new EscuelaModel();
        }
    }
}