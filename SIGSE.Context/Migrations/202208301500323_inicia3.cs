namespace SIGSE.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicia3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RolPermisoes", "Rol_idRol", "dbo.Rols");
            DropForeignKey("dbo.RolPermisoes", "Permiso_idPermiso", "dbo.Permisoes");
            DropForeignKey("dbo.UsuarioRols", "Usuario_idUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.UsuarioRols", "Rol_idRol", "dbo.Rols");
            CreateTable(
                "dbo.Cicloes",
                c => new
                    {
                        idCiclo = c.Int(nullable: false, identity: true),
                        fecha_inicio = c.DateTime(nullable: false),
                        cant_dias = c.Int(nullable: false),
                        objetivo_idObjetivo = c.Int(),
                        tipo_entrenamiento_idTipoEntrenamiento = c.Int(),
                    })
                .PrimaryKey(t => t.idCiclo)
                .ForeignKey("dbo.Objetivoes", t => t.objetivo_idObjetivo)
                .ForeignKey("dbo.TipoEntrenamientoes", t => t.tipo_entrenamiento_idTipoEntrenamiento)
                .Index(t => t.objetivo_idObjetivo)
                .Index(t => t.tipo_entrenamiento_idTipoEntrenamiento);
            
            CreateTable(
                "dbo.Objetivoes",
                c => new
                    {
                        idObjetivo = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        descripcion = c.String(),
                        diasMinimo = c.Int(nullable: false),
                        diasMaximo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idObjetivo);
            
            CreateTable(
                "dbo.Semanas",
                c => new
                    {
                        idSemana = c.Int(nullable: false, identity: true),
                        estado = c.Int(nullable: false),
                        Ciclo_idCiclo = c.Int(),
                    })
                .PrimaryKey(t => t.idSemana)
                .ForeignKey("dbo.Cicloes", t => t.Ciclo_idCiclo)
                .Index(t => t.Ciclo_idCiclo);
            
            CreateTable(
                "dbo.Dias",
                c => new
                    {
                        idDia = c.Int(nullable: false, identity: true),
                        Semana_idSemana = c.Int(),
                    })
                .PrimaryKey(t => t.idDia)
                .ForeignKey("dbo.Semanas", t => t.Semana_idSemana)
                .Index(t => t.Semana_idSemana);
            
            CreateTable(
                "dbo.EjercicioIntensidads",
                c => new
                    {
                        idEjercicioIntensidad = c.Int(nullable: false, identity: true),
                        series = c.Int(nullable: false),
                        repeticiones = c.Int(nullable: false),
                        peso = c.Single(nullable: false),
                        descanso = c.Int(nullable: false),
                        notas = c.String(),
                        ejercicio_idEjercicio = c.Int(),
                        Dia_idDia = c.Int(),
                    })
                .PrimaryKey(t => t.idEjercicioIntensidad)
                .ForeignKey("dbo.Ejercicios", t => t.ejercicio_idEjercicio)
                .ForeignKey("dbo.Dias", t => t.Dia_idDia)
                .Index(t => t.ejercicio_idEjercicio)
                .Index(t => t.Dia_idDia);
            
            CreateTable(
                "dbo.Ejercicios",
                c => new
                    {
                        idEjercicio = c.Int(nullable: false, identity: true),
                        tiempo = c.Boolean(nullable: false),
                        nombre = c.String(),
                        total = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idEjercicio);
            
            CreateTable(
                "dbo.Musculoes",
                c => new
                    {
                        idMusculo = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.idMusculo);
            
            CreateTable(
                "dbo.TipoEjercicios",
                c => new
                    {
                        idTipoEjercicio = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.idTipoEjercicio);
            
            CreateTable(
                "dbo.TipoEntrenamientoes",
                c => new
                    {
                        idTipoEntrenamiento = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.idTipoEntrenamiento);
            
            CreateTable(
                "dbo.Medidas",
                c => new
                    {
                        IdMedida = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        altura = c.Int(nullable: false),
                        peso = c.Int(nullable: false),
                        hombro = c.Int(nullable: false),
                        pecho = c.Int(nullable: false),
                        brazo = c.Int(nullable: false),
                        cintura = c.Int(nullable: false),
                        cadera = c.Int(nullable: false),
                        pierna = c.Int(nullable: false),
                        Alumno_idPersona = c.Int(),
                    })
                .PrimaryKey(t => t.IdMedida)
                .ForeignKey("dbo.Personas", t => t.Alumno_idPersona)
                .Index(t => t.Alumno_idPersona);
            
            CreateTable(
                "dbo.EjercicioMusculoes",
                c => new
                    {
                        Ejercicio_idEjercicio = c.Int(nullable: false),
                        Musculo_idMusculo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ejercicio_idEjercicio, t.Musculo_idMusculo })
                .ForeignKey("dbo.Ejercicios", t => t.Ejercicio_idEjercicio)
                .ForeignKey("dbo.Musculoes", t => t.Musculo_idMusculo)
                .Index(t => t.Ejercicio_idEjercicio)
                .Index(t => t.Musculo_idMusculo);
            
            CreateTable(
                "dbo.EjercicioTipoEjercicios",
                c => new
                    {
                        Ejercicio_idEjercicio = c.Int(nullable: false),
                        TipoEjercicio_idTipoEjercicio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ejercicio_idEjercicio, t.TipoEjercicio_idTipoEjercicio })
                .ForeignKey("dbo.Ejercicios", t => t.Ejercicio_idEjercicio)
                .ForeignKey("dbo.TipoEjercicios", t => t.TipoEjercicio_idTipoEjercicio)
                .Index(t => t.Ejercicio_idEjercicio)
                .Index(t => t.TipoEjercicio_idTipoEjercicio);
            
            CreateTable(
                "dbo.TipoEntrenamientoTipoEjercicios",
                c => new
                    {
                        TipoEntrenamiento_idTipoEntrenamiento = c.Int(nullable: false),
                        TipoEjercicio_idTipoEjercicio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TipoEntrenamiento_idTipoEntrenamiento, t.TipoEjercicio_idTipoEjercicio })
                .ForeignKey("dbo.TipoEntrenamientoes", t => t.TipoEntrenamiento_idTipoEntrenamiento)
                .ForeignKey("dbo.TipoEjercicios", t => t.TipoEjercicio_idTipoEjercicio)
                .Index(t => t.TipoEntrenamiento_idTipoEntrenamiento)
                .Index(t => t.TipoEjercicio_idTipoEjercicio);
            
            AddForeignKey("dbo.RolPermisoes", "Rol_idRol", "dbo.Rols", "idRol");
            AddForeignKey("dbo.RolPermisoes", "Permiso_idPermiso", "dbo.Permisoes", "idPermiso");
            AddForeignKey("dbo.UsuarioRols", "Usuario_idUsuario", "dbo.Usuarios", "idUsuario");
            AddForeignKey("dbo.UsuarioRols", "Rol_idRol", "dbo.Rols", "idRol");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsuarioRols", "Rol_idRol", "dbo.Rols");
            DropForeignKey("dbo.UsuarioRols", "Usuario_idUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.RolPermisoes", "Permiso_idPermiso", "dbo.Permisoes");
            DropForeignKey("dbo.RolPermisoes", "Rol_idRol", "dbo.Rols");
            DropForeignKey("dbo.Medidas", "Alumno_idPersona", "dbo.Personas");
            DropForeignKey("dbo.Cicloes", "tipo_entrenamiento_idTipoEntrenamiento", "dbo.TipoEntrenamientoes");
            DropForeignKey("dbo.TipoEntrenamientoTipoEjercicios", "TipoEjercicio_idTipoEjercicio", "dbo.TipoEjercicios");
            DropForeignKey("dbo.TipoEntrenamientoTipoEjercicios", "TipoEntrenamiento_idTipoEntrenamiento", "dbo.TipoEntrenamientoes");
            DropForeignKey("dbo.Semanas", "Ciclo_idCiclo", "dbo.Cicloes");
            DropForeignKey("dbo.Dias", "Semana_idSemana", "dbo.Semanas");
            DropForeignKey("dbo.EjercicioIntensidads", "Dia_idDia", "dbo.Dias");
            DropForeignKey("dbo.EjercicioIntensidads", "ejercicio_idEjercicio", "dbo.Ejercicios");
            DropForeignKey("dbo.EjercicioTipoEjercicios", "TipoEjercicio_idTipoEjercicio", "dbo.TipoEjercicios");
            DropForeignKey("dbo.EjercicioTipoEjercicios", "Ejercicio_idEjercicio", "dbo.Ejercicios");
            DropForeignKey("dbo.EjercicioMusculoes", "Musculo_idMusculo", "dbo.Musculoes");
            DropForeignKey("dbo.EjercicioMusculoes", "Ejercicio_idEjercicio", "dbo.Ejercicios");
            DropForeignKey("dbo.Cicloes", "objetivo_idObjetivo", "dbo.Objetivoes");
            DropIndex("dbo.TipoEntrenamientoTipoEjercicios", new[] { "TipoEjercicio_idTipoEjercicio" });
            DropIndex("dbo.TipoEntrenamientoTipoEjercicios", new[] { "TipoEntrenamiento_idTipoEntrenamiento" });
            DropIndex("dbo.EjercicioTipoEjercicios", new[] { "TipoEjercicio_idTipoEjercicio" });
            DropIndex("dbo.EjercicioTipoEjercicios", new[] { "Ejercicio_idEjercicio" });
            DropIndex("dbo.EjercicioMusculoes", new[] { "Musculo_idMusculo" });
            DropIndex("dbo.EjercicioMusculoes", new[] { "Ejercicio_idEjercicio" });
            DropIndex("dbo.Medidas", new[] { "Alumno_idPersona" });
            DropIndex("dbo.EjercicioIntensidads", new[] { "Dia_idDia" });
            DropIndex("dbo.EjercicioIntensidads", new[] { "ejercicio_idEjercicio" });
            DropIndex("dbo.Dias", new[] { "Semana_idSemana" });
            DropIndex("dbo.Semanas", new[] { "Ciclo_idCiclo" });
            DropIndex("dbo.Cicloes", new[] { "tipo_entrenamiento_idTipoEntrenamiento" });
            DropIndex("dbo.Cicloes", new[] { "objetivo_idObjetivo" });
            DropTable("dbo.TipoEntrenamientoTipoEjercicios");
            DropTable("dbo.EjercicioTipoEjercicios");
            DropTable("dbo.EjercicioMusculoes");
            DropTable("dbo.Medidas");
            DropTable("dbo.TipoEntrenamientoes");
            DropTable("dbo.TipoEjercicios");
            DropTable("dbo.Musculoes");
            DropTable("dbo.Ejercicios");
            DropTable("dbo.EjercicioIntensidads");
            DropTable("dbo.Dias");
            DropTable("dbo.Semanas");
            DropTable("dbo.Objetivoes");
            DropTable("dbo.Cicloes");
            AddForeignKey("dbo.UsuarioRols", "Rol_idRol", "dbo.Rols", "idRol", cascadeDelete: true);
            AddForeignKey("dbo.UsuarioRols", "Usuario_idUsuario", "dbo.Usuarios", "idUsuario", cascadeDelete: true);
            AddForeignKey("dbo.RolPermisoes", "Permiso_idPermiso", "dbo.Permisoes", "idPermiso", cascadeDelete: true);
            AddForeignKey("dbo.RolPermisoes", "Rol_idRol", "dbo.Rols", "idRol", cascadeDelete: true);
        }
    }
}
