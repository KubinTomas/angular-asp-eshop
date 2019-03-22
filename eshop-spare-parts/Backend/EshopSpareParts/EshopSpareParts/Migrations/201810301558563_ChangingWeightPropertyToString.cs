namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingWeightPropertyToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderTransports", "Weight", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderTransports", "Weight", c => c.Int(nullable: false));
        }
    }
}
