using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("SilaboFaseUnidad")]
    public class SilaboFaseUnidadModel : AuditoriaModel
    {
        public int Id { get; set; }
        public int IdSilaboFase { get; set; }
        [ForeignKey("IdSilaboFase")]
        public virtual SilaboFaseModel SilaboFase { get; set; }
        public int IdSilaboUnidad { get; set; }
        [ForeignKey("IdSilaboUnidad")]
        public virtual UnidadModel Unidad { get; set; }
        public int UnidadI { get; set; }
        public int SubUnidad { get; set; }
        public SilaboFaseUnidadModel()
        {
        }
    }
}