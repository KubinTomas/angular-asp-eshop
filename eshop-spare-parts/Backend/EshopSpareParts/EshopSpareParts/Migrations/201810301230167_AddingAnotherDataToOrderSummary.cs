namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAnotherDataToOrderSummary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompleteOrderSummaries", "DeliveryTown", c => c.String());
            AddColumn("dbo.CompleteOrderSummaries", "DeliveryTownNumber", c => c.String());
            AddColumn("dbo.CompleteOrderSummaries", "DeliveryTownStreet", c => c.String());
            AddColumn("dbo.CompleteOrderSummaries", "InvoiceTown", c => c.String());
            AddColumn("dbo.CompleteOrderSummaries", "InvoiceTownNumber", c => c.String());
            AddColumn("dbo.CompleteOrderSummaries", "InvoiceTownStreet", c => c.String());
            DropColumn("dbo.CompleteOrderSummaries", "Town");
            DropColumn("dbo.CompleteOrderSummaries", "TownNumber");
            DropColumn("dbo.CompleteOrderSummaries", "TownStreet");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CompleteOrderSummaries", "TownStreet", c => c.String());
            AddColumn("dbo.CompleteOrderSummaries", "TownNumber", c => c.String());
            AddColumn("dbo.CompleteOrderSummaries", "Town", c => c.String());
            DropColumn("dbo.CompleteOrderSummaries", "InvoiceTownStreet");
            DropColumn("dbo.CompleteOrderSummaries", "InvoiceTownNumber");
            DropColumn("dbo.CompleteOrderSummaries", "InvoiceTown");
            DropColumn("dbo.CompleteOrderSummaries", "DeliveryTownStreet");
            DropColumn("dbo.CompleteOrderSummaries", "DeliveryTownNumber");
            DropColumn("dbo.CompleteOrderSummaries", "DeliveryTown");
        }
    }
}
