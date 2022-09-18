namespace SIGSE.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accions", "AccionCompuesta_idAccion", "dbo.Accions");
            DropForeignKey("dbo.Accions", "AccionSimple_idAccion", "dbo.Accions");
            DropForeignKey("dbo.PermisoAccions", "Permiso_idPermiso", "dbo.Permisoes");
            DropForeignKey("dbo.PermisoAccions", "Accion_idAccion", "dbo.Accions");
            DropForeignKey("dbo.Rols", "permiso_idPermiso", "dbo.Permisoes");
            DropIndex("dbo.Accions", new[] { "AccionCompuesta_idAccion" });
            DropIndex("dbo.Accions", new[] { "AccionSimple_idAccion" });
            DropIndex("dbo.Rols", new[] { "permiso_idPermiso" });
            DropIndex("dbo.PermisoAccions", new[] { "Permiso_idPermiso" });
            DropIndex("dbo.PermisoAccions", new[] { "Accion_idAccion" });
            AddColumn("dbo.Permisoes", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Permisoes", "PermisoCompuesto_idPermiso", c => c.Int());
            AddColumn("dbo.Permisoes", "PermisoSimple_idPermiso", c => c.Int());
            AddColumn("dbo.Permisoes", "Rol_idRol", c => c.Int());
            CreateIndex("dbo.Permisoes", "PermisoCompuesto_idPermiso");
            CreateIndex("dbo.Permisoes", "PermisoSimple_idPermiso");
            CreateIndex("dbo.Permisoes", "Rol_idRol");
            AddForeignKey("dbo.Permisoes", "PermisoCompuesto_idPermiso", "dbo.Permisoes", "idPermiso");
            AddForeignKey("dbo.Permisoes", "PermisoSimple_idPermiso", "dbo.Permisoes", "idPermiso");
            AddForeignKey("dbo.Permisoes", "Rol_idRol", "dbo.Rols", "idRol");
            DropColumn("dbo.Rols", "permiso_idPermiso");
            DropTable("dbo.Accions");
            DropTable("dbo.PermisoAccions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PermisoAccions",
                c => new
                    {
                        Permiso_idPermiso = c.Int(nullable: false),
                        Accion_idAccion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Permiso_idPermiso, t.Accion_idAccion });
            
            CreateTable(
                "dbo.Accions",
                c => new
                    {
                        idAccion = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        AccionCompuesta_idAccion = c.Int(),
                        AccionSimple_idAccion = c.Int(),
                    })
                .PrimaryKey(t => t.idAccion);
            
            AddColumn("dbo.Rols", "permiso_idPermiso", c => c.Int());
            DropForeignKey("dbo.Permisoes", "Rol_idRol", "dbo.Rols");
            DropForeignKey("dbo.Permisoes", "PermisoSimple_idPermiso", "dbo.Permisoes");
            DropForeignKey("dbo.Permisoes", "PermisoCompuesto_idPermiso", "dbo.Permisoes");
            DropIndex("dbo.Permisoes", new[] { "Rol_idRol" });
            DropIndex("dbo.Permisoes", new[] { "PermisoSimple_idPermiso" });
            DropIndex("dbo.Permisoes", new[] { "PermisoCompuesto_idPermiso" });
            DropColumn("dbo.Permisoes", "Rol_idRol");
            DropColumn("dbo.Permisoes", "PermisoSimple_idPermiso");
            DropColumn("dbo.Permisoes", "PermisoCompuesto_idPermiso");
            DropColumn("dbo.Permisoes", "Discriminator");
            CreateIndex("dbo.PermisoAccions", "Accion_idAccion");
            CreateIndex("dbo.PermisoAccions", "Permiso_idPermiso");
            CreateIndex("dbo.Rols", "permiso_idPermiso");
            CreateIndex("dbo.Accions", "AccionSimple_idAccion");
            CreateIndex("dbo.Accions", "AccionCompuesta_idAccion");
            AddForeignKey("dbo.Rols", "permiso_idPermiso", "dbo.Permisoes", "idPermiso");
            AddForeignKey("dbo.PermisoAccions", "Accion_idAccion", "dbo.Accions", "idAccion", cascadeDelete: true);
            AddForeignKey("dbo.PermisoAccions", "Permiso_idPermiso", "dbo.Permisoes", "idPermiso", cascadeDelete: true);
            AddForeignKey("dbo.Accions", "AccionSimple_idAccion", "dbo.Accions", "idAccion");
            AddForeignKey("dbo.Accions", "AccionCompuesta_idAccion", "dbo.Accions", "idAccion");
        }
    }
}
