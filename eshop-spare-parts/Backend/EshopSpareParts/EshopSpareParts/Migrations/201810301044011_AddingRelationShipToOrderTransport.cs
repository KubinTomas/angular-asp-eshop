namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRelationShipToOrderTransport : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderTransportId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "OrderTransportId");
            AddForeignKey("dbo.Orders", "OrderTransportId", "dbo.OrderTransports", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "OrderTransportId", "dbo.OrderTransports");
            DropIndex("dbo.Orders", new[] { "OrderTransportId" });
            DropColumn("dbo.Orders", "OrderTransportId");
        }
    }
}
