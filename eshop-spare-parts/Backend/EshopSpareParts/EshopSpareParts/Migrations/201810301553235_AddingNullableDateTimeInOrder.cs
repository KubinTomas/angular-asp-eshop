namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNullableDateTimeInOrder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Finished", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Finished", c => c.DateTime(nullable: false));
        }
    }
}
