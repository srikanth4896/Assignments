using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach1.Models
{
    public class EmployeeTable
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " required")]
        [StringLength(30)]
        [MinLength(3)]
        public string EName { get; set; }

        public double ESalary { get; set; }
        public int DeptId { get; set; }
        public int MId { get; set; }

        public virtual DepartmentTable DepartmentTable { get; set; }
        public virtual ManagerTable ManagerTable { get; set; }
    }
}