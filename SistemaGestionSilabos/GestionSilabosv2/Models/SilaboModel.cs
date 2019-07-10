using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionSilabos.Models
{
    [Table("Silabo")]
    public class SilaboModel : AuditoriaModel
    {
        public int Id { get; set; }
        public int IdPlanFuncionamiento { get; set; }
        [ForeignKey("IdPlanFuncionamiento")]
        public virtual PlanFuncionamientoModel PlanFuncionamiento { get; set; }
        public int IdAsignatura { get; set; }
        [ForeignKey("IdAsignatura")]
        public virtual AsignaturaModel Asignaturas { get; set; }
        public string Sumilla { get; set; }
        public string AmbienteTeoria { get; set; }
        public string AmbientePractica { get; set; }
        public int AnioAcademico { get; set; }
        public int SelectedSilaboFase { get; set; }
        public virtual ICollection<SilaboFaseModel> SilaboFases { get; set; }
        public virtual ICollection<SilaboDocenteModel> SilaboDocentes { get; set; }
        public virtual ICollection<SilaboDivisionModel> SilaboDivisiones { get; set; }
        public SilaboModel()
        {
            SilaboFases = new HashSet<SilaboFaseModel>();
            SilaboDocentes = new HashSet<SilaboDocenteModel>();
            SilaboDivisiones = new HashSet<SilaboDivisionModel>();
        }
        public SilaboModel(int id, int idPlanFuncionamiento, string sumilla)
        {
            SilaboFases = new HashSet<SilaboFaseModel>();
        }
    }
}