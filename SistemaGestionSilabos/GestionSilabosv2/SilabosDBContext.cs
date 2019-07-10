using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GestionSilabos.Models;

namespace GestionSilabos
{
    public class SilabosDBContext : DbContext
    {
        public SilabosDBContext() : base("name=SilaboDBContext")
        {
        }

        public DbSet<AsignaturaCompetenciaModel> AsignaturaCompetencia { get; set; }
        public DbSet<AsignaturaModel> Asignatura { get; set; }
        public DbSet<CompetenciaCursoModel> CompetenciaCurso { get; set; }
        public DbSet<CompetenciaModel> Competencia { get; set; }
        public DbSet<CriterioModel> Criterio { get; set; }
        public DbSet<DepartamentoModel> Departamento { get; set; }
        public DbSet<DivisionModel> Division { get; set; }
        public DbSet<DocenteModel> Docente { get; set; }
        public DbSet<EscuelaModel> Escuela { get; set; }
        public DbSet<EstadoModel> Estado { get; set; }
        public DbSet<EstrategiaModel> Estrategia { get; set; }
        public DbSet<EvidenciaModel> Evidencia { get; set; }
        public DbSet<FacultadModel> Facultad { get; set; }
        public DbSet<FaseModel> Fase { get; set; }
        public DbSet<IdentificacionAcademicaModel> IdentificacionAcademica { get; set; }
        public DbSet<ParametricaModel> Parametrica { get; set; }
        public DbSet<PlanEstudioModel> PlanEstudio { get; set; }
        public DbSet<PlanFuncionamientoModel> PlanFuncionamiento { get; set; }
        public DbSet<SaberModel> Saber { get; set; }
        public DbSet<SilaboCompetenciaModel> SilaboCompetencia { get; set; }
        public DbSet<SilaboCriterioModel> SilaboCriterio { get; set; }
        public DbSet<SilaboDivisionModel> SilaboDivision { get; set; }
        public DbSet<SilaboDocenteModel> SilaboDocente { get; set; }
        public DbSet<SilaboEstrategiaModel> SilaboEstrategia { get; set; }
        public DbSet<SilaboEvidenciaModel> SilaboEvidencia { get; set; }
        public DbSet<SilaboFaseModel> SilaboFase { get; set; }
        public DbSet<SilaboFaseSaberModel> SilaboFaseSaber { get; set; }
        public DbSet<SilaboFaseUnidadModel> SilaboFaseUnidad { get; set; }
        public DbSet<SilaboModel> Silabo { get; set; }
        public DbSet<TipoDocenteModel> TipoDocente { get; set; }
        public DbSet<UnidadCursoModel> UnidadCurso { get; set; }
        public DbSet<UnidadModel> Unidad { get; set; }

    }
}