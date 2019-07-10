using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("SilaboDocente")]
    public class SilaboDocenteModel : AuditoriaModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdSilabo { get; set; }
        [ForeignKey("IdSilabo")]
        public virtual SilaboModel Silabo { get; set; }
        public int IdDocente { get; set; }
        [Required]
        [MaxLength(50)]
        public string Funcion { get; set; }
        [ForeignKey("IdDocente")]
        public virtual DocenteModel Docente { get; set; }
        [Required]
        [MaxLength(50)]
        public String Cargo { get; set; }

    }
}