namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingTransportCompaniesData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TransportCompanies (Name) VALUES ('�esk� po�ta')");
            Sql("INSERT INTO TransportCompanies (Name) VALUES ('DPD')");
        }
        
        public override void Down()
        {
        }
    }
}
