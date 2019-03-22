namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FakeDiscount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "FakeDiscount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "FakeDiscount");
        }
    }
}
