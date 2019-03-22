namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingImagePathToImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "ImagePath");
        }
    }
}
