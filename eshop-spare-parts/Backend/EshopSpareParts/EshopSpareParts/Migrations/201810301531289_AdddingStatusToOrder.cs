namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdddingStatusToOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "StatusId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "StatusId");
            AddForeignKey("dbo.Orders", "StatusId", "dbo.Status", "Id", cascadeDelete: true);
            DropColumn("dbo.Orders", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Status", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "StatusId", "dbo.Status");
            DropIndex("dbo.Orders", new[] { "StatusId" });
            DropColumn("dbo.Orders", "StatusId");
        }
    }
}
