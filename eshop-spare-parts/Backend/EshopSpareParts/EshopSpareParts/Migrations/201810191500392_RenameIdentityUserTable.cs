namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameIdentityUserTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "MyUsers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.MyUsers", newName: "AspNetUsers");
        }
    }
}
