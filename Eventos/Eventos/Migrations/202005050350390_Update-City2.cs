namespace Eventos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCity2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "Name", c => c.String());
            AlterColumn("dbo.Cities", "PostalCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "PostalCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Cities", "Name", c => c.Int(nullable: false));
        }
    }
}
