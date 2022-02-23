using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDemo.Models
{
    public partial class Employeedepartmentmapping
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
    }
}
