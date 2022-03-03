using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithEF.ViewModels
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string AlternateEmailId { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }

    }
}
