namespace Eventos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "City_Id", "dbo.Cities");
            DropIndex("dbo.Events", new[] { "City_Id" });
            RenameColumn(table: "dbo.Events", name: "City_Id", newName: "CityId");
            AlterColumn("dbo.Events", "CityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "CityId");
            AddForeignKey("dbo.Events", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "CityId", "dbo.Cities");
            DropIndex("dbo.Events", new[] { "CityId" });
            AlterColumn("dbo.Events", "CityId", c => c.Int());
            RenameColumn(table: "dbo.Events", name: "CityId", newName: "City_Id");
            CreateIndex("dbo.Events", "City_Id");
            AddForeignKey("dbo.Events", "City_Id", "dbo.Cities", "Id");
        }
    }
}
