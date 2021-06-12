using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp_Azure.Models
{
    public partial class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpSalary { get; set; }
    }
}
