using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("Departamento")]
    public class DepartamentoModel : AuditoriaModel
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int FacultadId { get; set; }
        [ForeignKey("FacultadId")]
        public virtual FacultadModel Facultad { get; set; }
    }
}