namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingPrizeToPriceInItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "Prize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Prize", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "Price");
        }
    }
}
