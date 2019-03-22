namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsVisibleToCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "IsVisible", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "IsVisible");
        }
    }
}
