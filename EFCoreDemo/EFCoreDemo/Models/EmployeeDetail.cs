using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDemo.Models
{
    public partial class EmployeeDetail
    {
        public int Id { get; set; }
        public string Employeename { get; set; }
        public string Gender { get; set; }
        public int? Salary { get; set; }
    }
}
