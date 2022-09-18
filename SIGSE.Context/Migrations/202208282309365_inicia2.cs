namespace SIGSE.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicia2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Permisoes", "Rol_idRol", "dbo.Rols");
            DropIndex("dbo.Permisoes", new[] { "Rol_idRol" });
            CreateTable(
                "dbo.RolPermisoes",
                c => new
                    {
                        Rol_idRol = c.Int(nullable: false),
                        Permiso_idPermiso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rol_idRol, t.Permiso_idPermiso })
                .ForeignKey("dbo.Rols", t => t.Rol_idRol, cascadeDelete: true)
                .ForeignKey("dbo.Permisoes", t => t.Permiso_idPermiso, cascadeDelete: true)
                .Index(t => t.Rol_idRol)
                .Index(t => t.Permiso_idPermiso);
            
            DropColumn("dbo.Permisoes", "Rol_idRol");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Permisoes", "Rol_idRol", c => c.Int());
            DropForeignKey("dbo.RolPermisoes", "Permiso_idPermiso", "dbo.Permisoes");
            DropForeignKey("dbo.RolPermisoes", "Rol_idRol", "dbo.Rols");
            DropIndex("dbo.RolPermisoes", new[] { "Permiso_idPermiso" });
            DropIndex("dbo.RolPermisoes", new[] { "Rol_idRol" });
            DropTable("dbo.RolPermisoes");
            CreateIndex("dbo.Permisoes", "Rol_idRol");
            AddForeignKey("dbo.Permisoes", "Rol_idRol", "dbo.Rols", "idRol");
        }
    }
}
