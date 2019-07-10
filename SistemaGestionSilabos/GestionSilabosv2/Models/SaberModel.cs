using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("Saber")]
    public class SaberModel : AuditoriaModel
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Orden { get; set; }
        public SaberModel()
        {

        }
    }
}