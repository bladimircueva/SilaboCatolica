using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("SilaboEstrategia")]
    public class SilaboEstrategiaModel : AuditoriaModel
    {
        public int Id { get; set; }
        public int IdEstrategia { get; set; }
        [ForeignKey("IdEstrategia")]
        public virtual EstrategiaModel Estrategia { get; set; }
        public int IdSilaboFasesSaberes { get; set; }
        [ForeignKey("IdSilaboFasesSaberes")]
        public virtual SilaboFaseSaberModel SilaboFasesSaberes { get; set; }
    }
}