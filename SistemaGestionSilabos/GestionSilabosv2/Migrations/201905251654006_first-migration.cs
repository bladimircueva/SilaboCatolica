namespace GestionSilabos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asignatura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Semestre = c.Int(nullable: false),
                        HorasSemanalesTeoricas = c.Single(nullable: false),
                        HorasSemanalesPracticaAula = c.Single(nullable: false),
                        HorasSemanalesPracticaJefe = c.Single(nullable: false),
                        HorasSemanalesVirtuales = c.Single(nullable: false),
                        HorasSemestralesTeorica = c.Single(nullable: false),
                        HorasSemestralesPractica = c.Single(nullable: false),
                        HorasSemestralesVirtuales = c.Single(nullable: false),
                        Creditos = c.Int(nullable: false),
                        IdPlanEstudio = c.Int(nullable: false),
                        IdDepartamento = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.IdDepartamento, cascadeDelete: true)
                .ForeignKey("dbo.PlanEstudio", t => t.IdPlanEstudio, cascadeDelete: true)
                .Index(t => t.IdPlanEstudio)
                .Index(t => t.IdDepartamento);
            
            CreateTable(
                "dbo.AsignaturaCompetencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCompetencia = c.Int(nullable: false),
                        IdAsignatura = c.Int(nullable: false),
                        IdSilaboFase = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Asignatura", t => t.IdAsignatura, cascadeDelete: true)
                .ForeignKey("dbo.Competencia", t => t.IdCompetencia, cascadeDelete: true)
                .ForeignKey("dbo.SilaboFase", t => t.IdSilaboFase, cascadeDelete: true)
                .Index(t => t.IdCompetencia)
                .Index(t => t.IdAsignatura)
                .Index(t => t.IdSilaboFase);
            
            CreateTable(
                "dbo.Competencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEscuelas = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Escuela", t => t.IdEscuelas, cascadeDelete: true)
                .Index(t => t.IdEscuelas);
            
            CreateTable(
                "dbo.Escuela",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        FacultadId = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facultad", t => t.FacultadId, cascadeDelete: true)
                .Index(t => t.FacultadId);
            
            CreateTable(
                "dbo.Facultad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SilaboFase",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdFase = c.Int(nullable: false),
                        IdSilabo = c.Int(nullable: false),
                        Titulo = c.String(),
                        HoraFase = c.Int(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fase", t => t.IdFase, cascadeDelete: true)
                .ForeignKey("dbo.Silabo", t => t.IdSilabo, cascadeDelete: true)
                .Index(t => t.IdFase)
                .Index(t => t.IdSilabo);
            
            CreateTable(
                "dbo.Fase",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Orden = c.String(),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Silabo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPlanFuncionamiento = c.Int(nullable: false),
                        IdAsignatura = c.Int(nullable: false),
                        Sumilla = c.String(),
                        AmbienteTeoria = c.String(),
                        AmbientePractica = c.String(),
                        AnioAcademico = c.Int(nullable: false),
                        SelectedSilaboFase = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Asignatura", t => t.IdAsignatura, cascadeDelete: false)
                .ForeignKey("dbo.PlanFuncionamiento", t => t.IdPlanFuncionamiento, cascadeDelete: true)
                .Index(t => t.IdPlanFuncionamiento)
                .Index(t => t.IdAsignatura);
            
            CreateTable(
                "dbo.PlanFuncionamiento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Anio = c.DateTime(nullable: false),
                        Semestre = c.String(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SilaboDivision",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdSilabo = c.Int(nullable: false),
                        IdDivision = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Division", t => t.IdDivision, cascadeDelete: true)
                .ForeignKey("dbo.Silabo", t => t.IdSilabo, cascadeDelete: true)
                .Index(t => t.IdSilabo)
                .Index(t => t.IdDivision);
            
            CreateTable(
                "dbo.Division",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Docente = c.String(),
                        Vista = c.String(),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SilaboDocente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdSilabo = c.Int(nullable: false),
                        IdDocente = c.Int(nullable: false),
                        Funcion = c.String(nullable: false, maxLength: 50),
                        Cargo = c.String(nullable: false, maxLength: 50),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Docente", t => t.IdDocente, cascadeDelete: true)
                .ForeignKey("dbo.Silabo", t => t.IdSilabo, cascadeDelete: true)
                .Index(t => t.IdSilabo)
                .Index(t => t.IdDocente);
            
            CreateTable(
                "dbo.Docente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 10),
                        ApellidoPaterno = c.String(nullable: false, maxLength: 50),
                        ApellidoMaterno = c.String(nullable: false, maxLength: 50),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        idTipoDocente = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoDocente", t => t.idTipoDocente, cascadeDelete: true)
                .Index(t => t.idTipoDocente);
            
            CreateTable(
                "dbo.TipoDocente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(nullable: false, maxLength: 100),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SilaboFaseSaber",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        IdSaberes = c.Int(nullable: false),
                        IdSilaboFase = c.Int(nullable: false),
                        ValorTeorico = c.Int(nullable: false),
                        ValorPractico = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Saber", t => t.IdSaberes, cascadeDelete: true)
                .ForeignKey("dbo.SilaboFase", t => t.IdSilaboFase, cascadeDelete: true)
                .Index(t => t.IdSaberes)
                .Index(t => t.IdSilaboFase);
            
            CreateTable(
                "dbo.Saber",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Orden = c.String(),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SilaboCriterio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCriterios = c.Int(nullable: false),
                        IdSilaboFasesSaberes = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criterio", t => t.IdCriterios, cascadeDelete: true)
                .ForeignKey("dbo.SilaboFaseSaber", t => t.IdSilaboFasesSaberes, cascadeDelete: true)
                .Index(t => t.IdCriterios)
                .Index(t => t.IdSilaboFasesSaberes);
            
            CreateTable(
                "dbo.Criterio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Orden = c.String(),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SilaboEstrategia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEstrategia = c.Int(nullable: false),
                        IdSilaboFasesSaberes = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estrategia", t => t.IdEstrategia, cascadeDelete: true)
                .ForeignKey("dbo.SilaboFaseSaber", t => t.IdSilaboFasesSaberes, cascadeDelete: true)
                .Index(t => t.IdEstrategia)
                .Index(t => t.IdSilaboFasesSaberes);
            
            CreateTable(
                "dbo.Estrategia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Orden = c.String(),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SilaboEvidencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEvidencia = c.Int(nullable: false),
                        IdSilaboFasesSaberes = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Evidencia", t => t.IdEvidencia, cascadeDelete: true)
                .ForeignKey("dbo.SilaboFaseSaber", t => t.IdSilaboFasesSaberes, cascadeDelete: true)
                .Index(t => t.IdEvidencia)
                .Index(t => t.IdSilaboFasesSaberes);
            
            CreateTable(
                "dbo.Evidencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Orden = c.String(),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SilaboFaseUnidad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdSilaboFase = c.Int(nullable: false),
                        IdSilaboUnidad = c.Int(nullable: false),
                        UnidadI = c.Int(nullable: false),
                        SubUnidad = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SilaboFase", t => t.IdSilaboFase, cascadeDelete: true)
                .ForeignKey("dbo.Unidad", t => t.IdSilaboUnidad, cascadeDelete: true)
                .Index(t => t.IdSilaboFase)
                .Index(t => t.IdSilaboUnidad);
            
            CreateTable(
                "dbo.Unidad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdAsignatura = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Asignatura", t => t.IdAsignatura, cascadeDelete: true)
                .Index(t => t.IdAsignatura);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        FacultadId = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facultad", t => t.FacultadId, cascadeDelete: false)
                .Index(t => t.FacultadId);
            
            CreateTable(
                "dbo.PlanEstudio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEscuela = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Escuela", t => t.IdEscuela, cascadeDelete: false)
                .Index(t => t.IdEscuela);
            
            CreateTable(
                "dbo.CompetenciaCurso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        IdFase = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(nullable: false, maxLength: 10),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentificacionAcademica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Escuela = c.String(),
                        Facultad = c.String(),
                        HorasSemanalesPracticaAula = c.Int(nullable: false),
                        HorasSemanalesPracticaJefe = c.Int(nullable: false),
                        HorasSemanalesPracticaVirtual = c.Int(nullable: false),
                        HorasSemestralesTeorica = c.Int(nullable: false),
                        HorasSemestralesPractica = c.Int(nullable: false),
                        HorasSemestralesVirtuales = c.Int(nullable: false),
                        Credito = c.Int(nullable: false),
                        HorasSemanalesTeorica = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parametrica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoControl = c.Int(nullable: false),
                        DescripcionControl = c.String(nullable: false, maxLength: 50),
                        Informacion = c.String(nullable: false, maxLength: 50),
                        valor = c.Int(nullable: false),
                        texto = c.String(nullable: false, maxLength: 50),
                        Auxiliar01 = c.Int(),
                        Auxiliar02 = c.Int(),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SilaboCompetencia",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        IdSilabo = c.Int(nullable: false),
                        IdDivision = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Division", t => t.IdDivision, cascadeDelete: true)
                .ForeignKey("dbo.Silabo", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.IdDivision);
            
            CreateTable(
                "dbo.UnidadCurso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubUnidad = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Estado = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(nullable: false, maxLength: 50),
                        UsuarioModificacion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SilaboCompetencia", "Id", "dbo.Silabo");
            DropForeignKey("dbo.SilaboCompetencia", "IdDivision", "dbo.Division");
            DropForeignKey("dbo.Asignatura", "IdPlanEstudio", "dbo.PlanEstudio");
            DropForeignKey("dbo.PlanEstudio", "IdEscuela", "dbo.Escuela");
            DropForeignKey("dbo.Asignatura", "IdDepartamento", "dbo.Departamento");
            DropForeignKey("dbo.Departamento", "FacultadId", "dbo.Facultad");
            DropForeignKey("dbo.SilaboFaseUnidad", "IdSilaboUnidad", "dbo.Unidad");
            DropForeignKey("dbo.Unidad", "IdAsignatura", "dbo.Asignatura");
            DropForeignKey("dbo.SilaboFaseUnidad", "IdSilaboFase", "dbo.SilaboFase");
            DropForeignKey("dbo.SilaboFaseSaber", "IdSilaboFase", "dbo.SilaboFase");
            DropForeignKey("dbo.SilaboEvidencia", "IdSilaboFasesSaberes", "dbo.SilaboFaseSaber");
            DropForeignKey("dbo.SilaboEvidencia", "IdEvidencia", "dbo.Evidencia");
            DropForeignKey("dbo.SilaboEstrategia", "IdSilaboFasesSaberes", "dbo.SilaboFaseSaber");
            DropForeignKey("dbo.SilaboEstrategia", "IdEstrategia", "dbo.Estrategia");
            DropForeignKey("dbo.SilaboCriterio", "IdSilaboFasesSaberes", "dbo.SilaboFaseSaber");
            DropForeignKey("dbo.SilaboCriterio", "IdCriterios", "dbo.Criterio");
            DropForeignKey("dbo.SilaboFaseSaber", "IdSaberes", "dbo.Saber");
            DropForeignKey("dbo.SilaboFase", "IdSilabo", "dbo.Silabo");
            DropForeignKey("dbo.SilaboDocente", "IdSilabo", "dbo.Silabo");
            DropForeignKey("dbo.SilaboDocente", "IdDocente", "dbo.Docente");
            DropForeignKey("dbo.Docente", "idTipoDocente", "dbo.TipoDocente");
            DropForeignKey("dbo.SilaboDivision", "IdSilabo", "dbo.Silabo");
            DropForeignKey("dbo.SilaboDivision", "IdDivision", "dbo.Division");
            DropForeignKey("dbo.Silabo", "IdPlanFuncionamiento", "dbo.PlanFuncionamiento");
            DropForeignKey("dbo.Silabo", "IdAsignatura", "dbo.Asignatura");
            DropForeignKey("dbo.SilaboFase", "IdFase", "dbo.Fase");
            DropForeignKey("dbo.AsignaturaCompetencia", "IdSilaboFase", "dbo.SilaboFase");
            DropForeignKey("dbo.AsignaturaCompetencia", "IdCompetencia", "dbo.Competencia");
            DropForeignKey("dbo.Competencia", "IdEscuelas", "dbo.Escuela");
            DropForeignKey("dbo.Escuela", "FacultadId", "dbo.Facultad");
            DropForeignKey("dbo.AsignaturaCompetencia", "IdAsignatura", "dbo.Asignatura");
            DropIndex("dbo.SilaboCompetencia", new[] { "IdDivision" });
            DropIndex("dbo.SilaboCompetencia", new[] { "Id" });
            DropIndex("dbo.PlanEstudio", new[] { "IdEscuela" });
            DropIndex("dbo.Departamento", new[] { "FacultadId" });
            DropIndex("dbo.Unidad", new[] { "IdAsignatura" });
            DropIndex("dbo.SilaboFaseUnidad", new[] { "IdSilaboUnidad" });
            DropIndex("dbo.SilaboFaseUnidad", new[] { "IdSilaboFase" });
            DropIndex("dbo.SilaboEvidencia", new[] { "IdSilaboFasesSaberes" });
            DropIndex("dbo.SilaboEvidencia", new[] { "IdEvidencia" });
            DropIndex("dbo.SilaboEstrategia", new[] { "IdSilaboFasesSaberes" });
            DropIndex("dbo.SilaboEstrategia", new[] { "IdEstrategia" });
            DropIndex("dbo.SilaboCriterio", new[] { "IdSilaboFasesSaberes" });
            DropIndex("dbo.SilaboCriterio", new[] { "IdCriterios" });
            DropIndex("dbo.SilaboFaseSaber", new[] { "IdSilaboFase" });
            DropIndex("dbo.SilaboFaseSaber", new[] { "IdSaberes" });
            DropIndex("dbo.Docente", new[] { "idTipoDocente" });
            DropIndex("dbo.SilaboDocente", new[] { "IdDocente" });
            DropIndex("dbo.SilaboDocente", new[] { "IdSilabo" });
            DropIndex("dbo.SilaboDivision", new[] { "IdDivision" });
            DropIndex("dbo.SilaboDivision", new[] { "IdSilabo" });
            DropIndex("dbo.Silabo", new[] { "IdAsignatura" });
            DropIndex("dbo.Silabo", new[] { "IdPlanFuncionamiento" });
            DropIndex("dbo.SilaboFase", new[] { "IdSilabo" });
            DropIndex("dbo.SilaboFase", new[] { "IdFase" });
            DropIndex("dbo.Escuela", new[] { "FacultadId" });
            DropIndex("dbo.Competencia", new[] { "IdEscuelas" });
            DropIndex("dbo.AsignaturaCompetencia", new[] { "IdSilaboFase" });
            DropIndex("dbo.AsignaturaCompetencia", new[] { "IdAsignatura" });
            DropIndex("dbo.AsignaturaCompetencia", new[] { "IdCompetencia" });
            DropIndex("dbo.Asignatura", new[] { "IdDepartamento" });
            DropIndex("dbo.Asignatura", new[] { "IdPlanEstudio" });
            DropTable("dbo.UnidadCurso");
            DropTable("dbo.SilaboCompetencia");
            DropTable("dbo.Parametrica");
            DropTable("dbo.IdentificacionAcademica");
            DropTable("dbo.Estado");
            DropTable("dbo.CompetenciaCurso");
            DropTable("dbo.PlanEstudio");
            DropTable("dbo.Departamento");
            DropTable("dbo.Unidad");
            DropTable("dbo.SilaboFaseUnidad");
            DropTable("dbo.Evidencia");
            DropTable("dbo.SilaboEvidencia");
            DropTable("dbo.Estrategia");
            DropTable("dbo.SilaboEstrategia");
            DropTable("dbo.Criterio");
            DropTable("dbo.SilaboCriterio");
            DropTable("dbo.Saber");
            DropTable("dbo.SilaboFaseSaber");
            DropTable("dbo.TipoDocente");
            DropTable("dbo.Docente");
            DropTable("dbo.SilaboDocente");
            DropTable("dbo.Division");
            DropTable("dbo.SilaboDivision");
            DropTable("dbo.PlanFuncionamiento");
            DropTable("dbo.Silabo");
            DropTable("dbo.Fase");
            DropTable("dbo.SilaboFase");
            DropTable("dbo.Facultad");
            DropTable("dbo.Escuela");
            DropTable("dbo.Competencia");
            DropTable("dbo.AsignaturaCompetencia");
            DropTable("dbo.Asignatura");
        }
    }
}
