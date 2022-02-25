using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithEF.ViewModels;

namespace WebApiWithEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("get-employee")]
        public IEnumerable<Employee> GetEmployee()
        {
            return new List<Employee>();
        }
        [HttpPost]
        [Route("save-employee")]
        public void SaveEmployee(Employee employee)
        {
            
        }

    }
}
