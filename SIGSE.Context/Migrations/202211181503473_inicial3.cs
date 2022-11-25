namespace SIGSE.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Semanas", "orden", c => c.Int(nullable: false));
            AddColumn("dbo.Semanas", "fecha_inicio", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Semanas", "fecha_inicio");
            DropColumn("dbo.Semanas", "orden");
        }
    }
}
