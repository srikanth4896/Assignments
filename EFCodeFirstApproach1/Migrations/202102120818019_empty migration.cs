namespace EFCodeFirstApproach1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emptymigration : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ManagerTables(MName) Values('Harini')");
            Sql("INSERT INTO ManagerTables(MName) Values('Ravi')");
            Sql("INSERT INTO ManagerTables(MName) Values('Kavya')");
            Sql("INSERT INTO ManagerTables(MName) Values('Vasudha')");
            Sql("INSERT INTO ManagerTables(MName) Values('Amisha')");
        }
        
        public override void Down()
        {
        }
    }
}
