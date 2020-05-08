namespace Eventos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Events", "City_Id", c => c.Int());
            CreateIndex("dbo.Events", "City_Id");
            AddForeignKey("dbo.Events", "City_Id", "dbo.Cities", "Id");
            DropColumn("dbo.Events", "City");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "City", c => c.String());
            DropForeignKey("dbo.Events", "City_Id", "dbo.Cities");
            DropIndex("dbo.Events", new[] { "City_Id" });
            DropColumn("dbo.Events", "City_Id");
            DropTable("dbo.Cities");
        }
    }
}
