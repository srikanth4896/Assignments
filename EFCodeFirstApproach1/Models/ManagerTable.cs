using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach1.Models
{
    public class ManagerTable
    {
        [Key]
        public int MId { get; set; }
        public string MName { get; set; }
    }
}