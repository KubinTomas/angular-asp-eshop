namespace EshopSpareParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulingSecondCategoryItems : DbMigration
    {
        public override void Up()
        {
            //Sql("DELETE FROM Categories WHERE id = 3");
            //Sql("DELETE FROM Categories WHERE id = 4"); 
            //Sql("DELETE FROM Categories WHERE id = 5");
            //Sql("DELETE FROM Categories WHERE id = 6");
            //Sql("DELETE FROM Categories WHERE id = 7");

            //Sql("INSERT INTO Categories (Title, ParentId) VALUES ('Škoda', 2)");
            //Sql("INSERT INTO Categories (Title, ParentId) VALUES ('Volkswagen', 2 )");
            //Sql("INSERT INTO Categories (Title, ParentId) VALUES ('Seat', 2 )");
            //Sql("INSERT INTO Categories (Title, ParentId) VALUES ('Audi', 2 )");
            //Sql("INSERT INTO Categories (Title, ParentId) VALUES ('Bmw', 2 )");

        
        }
        
        public override void Down()
        {
        }
    }
}
