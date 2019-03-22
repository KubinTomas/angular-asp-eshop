namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewUserTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "MyUsers");
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Town = c.String(),
                        TownNumber = c.String(),
                        TownStreet = c.String(),
                        IsAnonymous = c.Boolean(nullable: false),
                        AgreeTransaction = c.Boolean(nullable: false),
                        AgreeRegistration = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            RenameTable(name: "dbo.MyUsers", newName: "AspNetUsers");
        }
    }
}
