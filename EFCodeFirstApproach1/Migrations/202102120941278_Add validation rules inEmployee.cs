namespace EFCodeFirstApproach1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddvalidationrulesinEmployee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeTables", "EName", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeTables", "EName", c => c.String());
        }
    }
}
