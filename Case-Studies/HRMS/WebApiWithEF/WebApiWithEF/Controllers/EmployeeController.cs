using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithEF.Models;
using WebApiWithEF.ViewModels;

namespace WebApiWithEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly HRMSContext _hrmscontext;

        public EmployeeController(ILogger<EmployeeController> logger, HRMSContext hrmscontext)
        {
            _logger = logger;
            _hrmscontext = hrmscontext;
        }
        [HttpGet]
        [Route("get-employee")]
        public IEnumerable<TblEmployee> GetEmployee()
        {
            return _hrmscontext.TblEmployees;
        }
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        [Route("save-employee")]
        public void SaveEmployee([FromForm]Employee employee)
        {

            //creating employee
            var employeeData = new TblEmployee();
            
            employeeData.FirstName = employee.FirstName;
            employeeData.LastName = employee.LastName;
            employeeData.EmailId= employee.EmailID;
            employeeData.AlternateEmailId = employee.AlternateEmailId;
            employeeData.Gender = (employee.Gender.ToLower()=="male")?1:0;
            employeeData.Age = employee.Age;
            employeeData.Salary = employee.Salary;
            employeeData.Dob = employee.DOB;
            employeeData.DateOfJoining = employee.DOJ;
            employeeData.CreatedOn = DateTime.Now;
            employeeData.UpdatedOn= DateTime.Now;
            employeeData.IsDeleted = 0;
            _hrmscontext.TblEmployees.Add(employeeData);
            _hrmscontext.SaveChanges();
            employeeData.EmployeeId = "CAP" + employeeData.Id;
            employeeData.CreatedBy = employeeData.Id;
            employeeData.UpdatedBy = employeeData.Id;
            _hrmscontext.SaveChanges();

            //creating user login
            var UserLogin = new TblLogin();
            UserLogin.CreatedOn = DateTime.Now;
            UserLogin.IsDeleted = 0;
            UserLogin.UpdatedOn =DateTime.Now;
            UserLogin.UserName = employee.EmailID;
            UserLogin.Password = employee.DOB.ToString("ddMMyyyy");
            _hrmscontext.TblLogins.Add(UserLogin);
            _hrmscontext.SaveChanges();
            employeeData.CreatedBy = UserLogin.Id;
            employeeData.UpdatedBy = UserLogin.Id;
            _hrmscontext.SaveChanges();
        }

    }
}
