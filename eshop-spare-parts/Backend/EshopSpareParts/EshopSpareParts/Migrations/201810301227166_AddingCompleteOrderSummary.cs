namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCompleteOrderSummary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompleteOrderSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Surname = c.Int(nullable: false),
                        Email = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Town = c.String(),
                        TownNumber = c.String(),
                        TownStreet = c.String(),
                        TotalPrice = c.Int(nullable: false),
                        OrderTransportId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderTransports", t => t.OrderTransportId, cascadeDelete: true)
                .Index(t => t.OrderTransportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompleteOrderSummaries", "OrderTransportId", "dbo.OrderTransports");
            DropIndex("dbo.CompleteOrderSummaries", new[] { "OrderTransportId" });
            DropTable("dbo.CompleteOrderSummaries");
        }
    }
}
