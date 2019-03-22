namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingOrderSummaryValuesToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CompleteOrderSummaries", "Name", c => c.String());
            AlterColumn("dbo.CompleteOrderSummaries", "Surname", c => c.String());
            AlterColumn("dbo.CompleteOrderSummaries", "Email", c => c.String());
            AlterColumn("dbo.CompleteOrderSummaries", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CompleteOrderSummaries", "Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.CompleteOrderSummaries", "Email", c => c.Int(nullable: false));
            AlterColumn("dbo.CompleteOrderSummaries", "Surname", c => c.Int(nullable: false));
            AlterColumn("dbo.CompleteOrderSummaries", "Name", c => c.Int(nullable: false));
        }
    }
}
