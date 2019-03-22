namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRelationshipOrderAndOrderClasses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "UserId" });
            AddColumn("dbo.Orders", "PersonalDataId", c => c.Int());
            AddColumn("dbo.Orders", "BillingAddressId", c => c.Int());
            AddColumn("dbo.Orders", "OrderDifferentDataAndAddressId", c => c.Int());
            AlterColumn("dbo.Orders", "UserId", c => c.Int());
            CreateIndex("dbo.Orders", "UserId");
            CreateIndex("dbo.Orders", "PersonalDataId");
            CreateIndex("dbo.Orders", "BillingAddressId");
            CreateIndex("dbo.Orders", "OrderDifferentDataAndAddressId");
            AddForeignKey("dbo.Orders", "BillingAddressId", "dbo.BillingAddresses", "Id");
            AddForeignKey("dbo.Orders", "OrderDifferentDataAndAddressId", "dbo.OrderDifferentDataAndAddresses", "Id");
            AddForeignKey("dbo.Orders", "PersonalDataId", "dbo.PersonalDatas", "Id");
            AddForeignKey("dbo.Orders", "UserId", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.Orders", "PersonalDataId", "dbo.PersonalDatas");
            DropForeignKey("dbo.Orders", "OrderDifferentDataAndAddressId", "dbo.OrderDifferentDataAndAddresses");
            DropForeignKey("dbo.Orders", "BillingAddressId", "dbo.BillingAddresses");
            DropIndex("dbo.Orders", new[] { "OrderDifferentDataAndAddressId" });
            DropIndex("dbo.Orders", new[] { "BillingAddressId" });
            DropIndex("dbo.Orders", new[] { "PersonalDataId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            AlterColumn("dbo.Orders", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "OrderDifferentDataAndAddressId");
            DropColumn("dbo.Orders", "BillingAddressId");
            DropColumn("dbo.Orders", "PersonalDataId");
            CreateIndex("dbo.Orders", "UserId");
            AddForeignKey("dbo.Orders", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
