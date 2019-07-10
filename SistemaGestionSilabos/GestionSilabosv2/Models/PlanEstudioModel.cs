using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("PlanEstudio")]
    public class PlanEstudioModel : AuditoriaModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdEscuela { get; set; }
        [ForeignKey("IdEscuela")]
        public virtual EscuelaModel Escuela { get; set; }
    }
}