namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingFilterWordToCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "FilterWord", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "FilterWord");
        }
    }
}
