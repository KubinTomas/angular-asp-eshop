namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingModelsForOder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillingAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Town = c.String(),
                        TownNumber = c.String(),
                        TownStreet = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDifferentDataAndAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Surname = c.Int(nullable: false),
                        Email = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Town = c.String(),
                        TownNumber = c.String(),
                        TownStreet = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonalDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Surname = c.Int(nullable: false),
                        Email = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PersonalDatas");
            DropTable("dbo.OrderDifferentDataAndAddresses");
            DropTable("dbo.BillingAddresses");
        }
    }
}
