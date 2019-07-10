using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("Division")]
    public class DivisionModel : AuditoriaModel
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Docente { get; set; }
        public String Vista { get; set; }
        public DivisionModel()
        {
        }
    }
}