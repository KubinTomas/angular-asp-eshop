namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRelationShipUserArticle : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Articles", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Articles", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Articles", "ApplicationUserId");
            DropColumn("dbo.Articles", "ApplicationUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Articles", "ApplicationUserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Articles", "ApplicationUser_Id");
            AddForeignKey("dbo.Articles", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
