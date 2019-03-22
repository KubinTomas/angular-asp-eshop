namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingOrderTransport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderTransports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransportCompanyId = c.Int(nullable: false),
                        TransportPrice = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TransportCompanies", t => t.TransportCompanyId, cascadeDelete: true)
                .Index(t => t.TransportCompanyId);
            
            AddColumn("dbo.OrderItems", "ItemPrice", c => c.Int(nullable: false));
            AddColumn("dbo.OrderItems", "ItemCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderTransports", "TransportCompanyId", "dbo.TransportCompanies");
            DropIndex("dbo.OrderTransports", new[] { "TransportCompanyId" });
            DropColumn("dbo.OrderItems", "ItemCount");
            DropColumn("dbo.OrderItems", "ItemPrice");
            DropTable("dbo.OrderTransports");
        }
    }
}
