using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("SilaboFaseSaber")]
    public class SilaboFaseSaberModel : AuditoriaModel
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public int IdSaberes { get; set; }
        [ForeignKey("IdSaberes")]
        public virtual SaberModel Saberes { get; set; }
        public int IdSilaboFase { get; set; }
        [ForeignKey("IdSilaboFase")]
        public virtual SilaboFaseModel SilaboFase { get; set; }
        public int ValorTeorico { get; set; }
        public int ValorPractico { get; set; }
        public virtual ICollection<SilaboEvidenciaModel> SilaboEvidencias { get; set; }
        public virtual ICollection<SilaboCriterioModel> SilaboCriterios { get; set; }
        public virtual ICollection<SilaboEstrategiaModel> SilaboEstrategias { get; set; }
        public SilaboFaseSaberModel()
        {
            SilaboEvidencias = new HashSet<SilaboEvidenciaModel>();
            SilaboCriterios = new HashSet<SilaboCriterioModel>();
            SilaboEstrategias = new HashSet<SilaboEstrategiaModel>();
        }
    }
}