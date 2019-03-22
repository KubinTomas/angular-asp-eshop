namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingUserRelationShipToNewOne : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MyUsers", newName: "AspNetUsers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "MyUsers");
        }
    }
}
