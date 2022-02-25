using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithEF.ViewModels
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
    }
}
