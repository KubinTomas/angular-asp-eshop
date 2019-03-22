namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingItemDeliveryDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "DeliveryDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "DeliveryDate");
        }
    }
}
