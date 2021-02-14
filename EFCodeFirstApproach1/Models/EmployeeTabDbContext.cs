using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach1.Models
{
    public class EmployeeTabDbContext:DbContext
    {
        public EmployeeTabDbContext() : base("conn")
        {

        }
        public DbSet<DepartmentTable> Departments { get; set; }
        public DbSet<EmployeeTable> Employees { get; set; }
        public DbSet<ManagerTable> Manager { get; set; }

    }
}