using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace GestionSilabos.Models
{
    [Table("PlanFuncionamiento")]
    public class PlanFuncionamientoModel : AuditoriaModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime Anio { get; set; }
        [Required]
        public String Semestre { get; set; }
        public PlanFuncionamientoModel()
        {

        }
    }
}