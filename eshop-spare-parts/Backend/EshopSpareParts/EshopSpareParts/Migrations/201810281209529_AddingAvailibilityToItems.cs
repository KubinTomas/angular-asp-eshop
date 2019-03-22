namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAvailibilityToItems : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ItemAvailabilityId", c => c.Int(nullable: true));

            Sql(@"UPDATE dbo.Items SET ItemAvailabilityId = 2
              where ItemAvailabilityId IS NULL");

            AlterColumn("dbo.Items", "ItemAvailabilityId", c => c.Int(nullable: false));

            CreateIndex("dbo.Items", "ItemAvailabilityId");
            AddForeignKey("dbo.Items", "ItemAvailabilityId", "dbo.ItemAvailabilities", "Id", cascadeDelete: true);

     
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ItemAvailabilityId", "dbo.ItemAvailabilities");
            DropIndex("dbo.Items", new[] { "ItemAvailabilityId" });
            DropColumn("dbo.Items", "ItemAvailabilityId");
        }
    }
}
