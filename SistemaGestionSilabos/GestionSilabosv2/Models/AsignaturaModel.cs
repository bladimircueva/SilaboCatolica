using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("Asignatura")]
    public class AsignaturaModel:AuditoriaModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public String Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public String Codigo { get; set; }
        [Required]
        public int Semestre { get; set; }
        [Required]
        public float HorasSemanalesTeoricas { get; set; }
        [Required]
        public float HorasSemanalesPracticaAula { get; set; }
        [Required]
        public float HorasSemanalesPracticaJefe { get; set; }
        [Required]
        public float HorasSemanalesVirtuales { get; set; }
        [Required]
        public float HorasSemestralesTeorica { get; set; }
        [Required]
        public float HorasSemestralesPractica { get; set; }
        [Required]
        public float HorasSemestralesVirtuales { get; set; }
        [Required]
        public int Creditos { get; set; }
        [Required]
        public int IdPlanEstudio { get; set; }
        [ForeignKey("IdPlanEstudio")]
        public virtual PlanEstudioModel PlanEstudio { get; set; }
        public int IdDepartamento { get; set; }
        [ForeignKey("IdDepartamento")]
        public virtual DepartamentoModel Departamento { get; set; }
        
        public virtual ICollection<AsignaturaCompetenciaModel> AsignaturaCompetencias { get; set; }
        public IEnumerable<FaseModel> Fase { get; set; }
        public ICollection<UnidadModel> Unidades { get; set; }
        AsignaturaModel()
        {
            AsignaturaCompetencias = new HashSet<AsignaturaCompetenciaModel>();
            Unidades = new HashSet<UnidadModel>();    
        }
    }
}