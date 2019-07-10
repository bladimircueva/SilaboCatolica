using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionSilabos.Models
{
    [Table("AsignaturaCompetencia")]
    public class AsignaturaCompetenciaModel : AuditoriaModel
    {
        public int Id { get; set; }
        public int IdCompetencia { get; set; }
        [ForeignKey("IdCompetencia")]
        public virtual CompetenciaModel Competencia { get; set; }
        public int IdAsignatura { get; set; }
        [ForeignKey("IdAsignatura")]
        public virtual AsignaturaModel Asignaturas { get; set; }
        public int IdSilaboFase { get; set; }
        [ForeignKey("IdSilaboFase")]
        public virtual SilaboFaseModel SilaboFase { get; set; }
        public AsignaturaCompetenciaModel()
        {
        }
    }
}