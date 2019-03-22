namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingWeightToITem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Weight", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Weight");
        }
    }
}
