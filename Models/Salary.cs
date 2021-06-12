using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp_Azure.Models
{
    public partial class Salary
    {
        public int Pbid { get; set; }
        public string PayBand { get; set; }
        public double? BasicSalary { get; set; }
    }
}
