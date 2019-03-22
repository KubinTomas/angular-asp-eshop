namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingItemAvailabilityTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemAvailabilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ItemAvailabilities");
        }
    }
}
