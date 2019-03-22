namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingRelationshipsInOrder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "BillingAddressId", "dbo.BillingAddresses");
            DropForeignKey("dbo.Orders", "OrderDifferentDataAndAddressId", "dbo.OrderDifferentDataAndAddresses");
            DropForeignKey("dbo.Orders", "OrderTransportId", "dbo.OrderTransports");
            DropForeignKey("dbo.Orders", "PersonalDataId", "dbo.PersonalDatas");
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Orders", new[] { "PersonalDataId" });
            DropIndex("dbo.Orders", new[] { "BillingAddressId" });
            DropIndex("dbo.Orders", new[] { "OrderDifferentDataAndAddressId" });
            DropIndex("dbo.Orders", new[] { "OrderTransportId" });
            AddColumn("dbo.CompleteOrderSummaries", "UserId", c => c.Int());
            AddColumn("dbo.Orders", "CompleteOrderSummaryId", c => c.Int(nullable: false));
            CreateIndex("dbo.CompleteOrderSummaries", "UserId");
            CreateIndex("dbo.Orders", "CompleteOrderSummaryId");
            AddForeignKey("dbo.CompleteOrderSummaries", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Orders", "CompleteOrderSummaryId", "dbo.CompleteOrderSummaries", "Id", cascadeDelete: true);
            DropColumn("dbo.Orders", "UserId");
            DropColumn("dbo.Orders", "PersonalDataId");
            DropColumn("dbo.Orders", "BillingAddressId");
            DropColumn("dbo.Orders", "OrderDifferentDataAndAddressId");
            DropColumn("dbo.Orders", "OrderTransportId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderTransportId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "OrderDifferentDataAndAddressId", c => c.Int());
            AddColumn("dbo.Orders", "BillingAddressId", c => c.Int());
            AddColumn("dbo.Orders", "PersonalDataId", c => c.Int());
            AddColumn("dbo.Orders", "UserId", c => c.Int());
            DropForeignKey("dbo.Orders", "CompleteOrderSummaryId", "dbo.CompleteOrderSummaries");
            DropForeignKey("dbo.CompleteOrderSummaries", "UserId", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "CompleteOrderSummaryId" });
            DropIndex("dbo.CompleteOrderSummaries", new[] { "UserId" });
            DropColumn("dbo.Orders", "CompleteOrderSummaryId");
            DropColumn("dbo.CompleteOrderSummaries", "UserId");
            CreateIndex("dbo.Orders", "OrderTransportId");
            CreateIndex("dbo.Orders", "OrderDifferentDataAndAddressId");
            CreateIndex("dbo.Orders", "BillingAddressId");
            CreateIndex("dbo.Orders", "PersonalDataId");
            CreateIndex("dbo.Orders", "UserId");
            AddForeignKey("dbo.Orders", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Orders", "PersonalDataId", "dbo.PersonalDatas", "Id");
            AddForeignKey("dbo.Orders", "OrderTransportId", "dbo.OrderTransports", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "OrderDifferentDataAndAddressId", "dbo.OrderDifferentDataAndAddresses", "Id");
            AddForeignKey("dbo.Orders", "BillingAddressId", "dbo.BillingAddresses", "Id");
        }
    }
}
