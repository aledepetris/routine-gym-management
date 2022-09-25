namespace SIGSE.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AuditoriaLogins", "usuario_idUsuario", "dbo.Usuarios");
            DropIndex("dbo.AuditoriaLogins", new[] { "usuario_idUsuario" });
            AddColumn("dbo.AuditoriaLogins", "username", c => c.String());
            DropColumn("dbo.AuditoriaLogins", "usuario_idUsuario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AuditoriaLogins", "usuario_idUsuario", c => c.Int());
            DropColumn("dbo.AuditoriaLogins", "username");
            CreateIndex("dbo.AuditoriaLogins", "usuario_idUsuario");
            AddForeignKey("dbo.AuditoriaLogins", "usuario_idUsuario", "dbo.Usuarios", "idUsuario");
        }
    }
}
