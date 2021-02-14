namespace EFCodeFirstApproach1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addemployeedepartmentandmanagertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartmentTables",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.EmployeeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EName = c.String(),
                        ESalary = c.Double(nullable: false),
                        DeptId = c.Int(nullable: false),
                        MId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentTables", t => t.DeptId, cascadeDelete: true)
                .ForeignKey("dbo.ManagerTables", t => t.MId, cascadeDelete: true)
                .Index(t => t.DeptId)
                .Index(t => t.MId);
            
            CreateTable(
                "dbo.ManagerTables",
                c => new
                    {
                        MId = c.Int(nullable: false, identity: true),
                        MName = c.String(),
                    })
                .PrimaryKey(t => t.MId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeTables", "MId", "dbo.ManagerTables");
            DropForeignKey("dbo.EmployeeTables", "DeptId", "dbo.DepartmentTables");
            DropIndex("dbo.EmployeeTables", new[] { "MId" });
            DropIndex("dbo.EmployeeTables", new[] { "DeptId" });
            DropTable("dbo.ManagerTables");
            DropTable("dbo.EmployeeTables");
            DropTable("dbo.DepartmentTables");
        }
    }
}
