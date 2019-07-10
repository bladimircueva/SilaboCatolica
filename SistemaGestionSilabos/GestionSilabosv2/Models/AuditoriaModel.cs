using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    public class AuditoriaModel
    {
        public int Estado { get; set; }
        public DateTime? FechaModificacion { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required]
        [MaxLength(50)]
        public String UsuarioCreacion { get; set; }
        [MaxLength(50)]
        public String UsuarioModificacion { get; set; }
    }
}