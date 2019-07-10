using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("SilaboCompetencia")]
    public class SilaboCompetenciaModel : AuditoriaModel
    {

        public int Id { get; set; }
        public int IdSilabo { get; set; }
        [ForeignKey("Id")]
        public virtual SilaboModel Silabo { get; set; }
        public int IdDivision { get; set; }
        [ForeignKey("IdDivision")]
        public virtual DivisionModel Division { get; set; }
        SilaboCompetenciaModel()
        {

        }
    }
}