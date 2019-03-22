namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMorePropertiesToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "Surname", c => c.String());
            AddColumn("dbo.AspNetUsers", "Town", c => c.String());
            AddColumn("dbo.AspNetUsers", "TownNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "TownStreet", c => c.String());
            AddColumn("dbo.AspNetUsers", "IsAnonymous", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "AgreeTransaction", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "AgreeRegistration", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AgreeRegistration");
            DropColumn("dbo.AspNetUsers", "AgreeTransaction");
            DropColumn("dbo.AspNetUsers", "IsAnonymous");
            DropColumn("dbo.AspNetUsers", "TownStreet");
            DropColumn("dbo.AspNetUsers", "TownNumber");
            DropColumn("dbo.AspNetUsers", "Town");
            DropColumn("dbo.AspNetUsers", "Surname");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
