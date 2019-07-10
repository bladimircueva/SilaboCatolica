using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("SilaboEvidencia")]
    public class SilaboEvidenciaModel : AuditoriaModel
    {
        public int Id { get; set; }
        public int IdEvidencia { get; set; }
        [ForeignKey("IdEvidencia")]
        public virtual EvidenciaModel Evidencias { get; set; }
        public int IdSilaboFasesSaberes { get; set; }
        [ForeignKey("IdSilaboFasesSaberes")]
        public virtual SilaboFaseSaberModel SilaboFasesSaberes { get; set; }
    }
}