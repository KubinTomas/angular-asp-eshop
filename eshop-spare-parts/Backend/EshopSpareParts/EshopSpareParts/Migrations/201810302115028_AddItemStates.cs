namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemStates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItemStates", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ItemStates", "Name", c => c.Int(nullable: false));
        }
    }
}
