namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingStatuesToStatusTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Code) VALUES ('Pending')");
            Sql("INSERT INTO Status (Code) VALUES ('Confirmed')");
            Sql("INSERT INTO Status (Code) VALUES ('Finished')");
        }
        
        public override void Down()
        {
        }
    }
}
