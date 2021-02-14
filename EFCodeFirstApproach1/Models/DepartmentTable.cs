using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach1.Models
{
    public class DepartmentTable
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }

    }
}