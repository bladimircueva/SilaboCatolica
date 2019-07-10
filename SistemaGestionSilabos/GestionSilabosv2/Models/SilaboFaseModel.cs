using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("SilaboFase")]
    public class SilaboFaseModel:AuditoriaModel
    {
        public int Id { get; set; }
        public int IdFase { get; set; }
        [ForeignKey("IdFase")]
        public virtual FaseModel Fase{ get; set; }
        public int IdSilabo { get; set; }
        [ForeignKey("IdSilabo")]
        public virtual SilaboModel Silabo { get; set; }
        [Display(Name = "Titulo de fase")]
        public string Titulo { get; set; }
        public int HoraFase { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        public DateTime FechaInicio { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        public DateTime FechaFin { get; set; }        
        public virtual ICollection<SilaboFaseSaberModel> SilaboFasesSaberes { get; set; }
        public virtual ICollection<AsignaturaCompetenciaModel> AsignaturaCompetencias { get; set; }
        public virtual ICollection<SilaboFaseUnidadModel> SilaboFaseUnidades  { get; set; }
        public virtual IEnumerable<SaberModel> Saberes { get; set; }
        public SilaboFaseModel()
        {
            AsignaturaCompetencias = new HashSet<AsignaturaCompetenciaModel>();
            SilaboFasesSaberes = new HashSet<SilaboFaseSaberModel>();
            SilaboFaseUnidades = new HashSet<SilaboFaseUnidadModel>();
        }
    }
}