using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("SilaboCriterio")]
    public class SilaboCriterioModel:AuditoriaModel
    {
        public int Id { get; set; }
        public int IdCriterios { get; set; }
        [ForeignKey("IdCriterios")]
        public virtual CriterioModel Criterios { get; set; }
        public int IdSilaboFasesSaberes { get; set; }
        [ForeignKey("IdSilaboFasesSaberes")]
        public virtual SilaboFaseSaberModel SilaboFasesSaberes { get; set; }
        
    }
}