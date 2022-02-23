using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDemo.Models
{
    public partial class Employee
    {
        public int? Employeeid { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public int? Salary { get; set; }
    }
}
