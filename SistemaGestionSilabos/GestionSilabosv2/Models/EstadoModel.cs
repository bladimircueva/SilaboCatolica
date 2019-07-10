using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("Estado")]
    public class EstadoModel : AuditoriaModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public String descripcion { get; set; }

    }
}