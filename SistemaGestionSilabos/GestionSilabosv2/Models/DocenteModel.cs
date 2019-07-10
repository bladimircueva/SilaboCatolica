using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("Docente")]
    public class DocenteModel : AuditoriaModel
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public String Codigo { get; set; }

        [Required]
        [MaxLength(50)]
        public String ApellidoPaterno { get; set; }

        [Required]
        [MaxLength(50)]
        public String ApellidoMaterno { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombres { get; set; }
        public int idTipoDocente { get; set; }
        [ForeignKey("idTipoDocente")]
        public virtual TipoDocenteModel TipoDocente { get; set; }
        public DocenteModel()
        {
            //this.TipoDocente = new TipoDocente();

        }
    }
}