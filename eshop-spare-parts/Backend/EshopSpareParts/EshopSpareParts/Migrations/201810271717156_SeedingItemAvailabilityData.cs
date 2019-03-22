namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingItemAvailabilityData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItemAvailabilities", "Title", c => c.String());

            Sql("INSERT INTO ItemAvailabilities (Title) VALUES ('Skladem')");
            Sql("INSERT INTO ItemAvailabilities (Title) VALUES ('Vyprodáno')");
            Sql("INSERT INTO ItemAvailabilities (Title) VALUES ('Na dotaz')");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ItemAvailabilities", "Title", c => c.Int(nullable: false));
        }
    }
}
