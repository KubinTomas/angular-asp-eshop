namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddingItemState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ItemStateId", c => c.Int(nullable: true));

            Sql(@"UPDATE dbo.Items SET ItemStateId = 1
              where ItemStateId IS NULL");

            AlterColumn("dbo.Items", "ItemStateId", c => c.Int(nullable: false));


            CreateIndex("dbo.Items", "ItemStateId");
            AddForeignKey("dbo.Items", "ItemStateId", "dbo.ItemStates", "Id", cascadeDelete: true);



        }

        public override void Down()
        {
            DropForeignKey("dbo.Items", "ItemStateId", "dbo.ItemStates");
            DropIndex("dbo.Items", new[] { "ItemStateId" });
            DropColumn("dbo.Items", "ItemStateId");
        }
    }
}
