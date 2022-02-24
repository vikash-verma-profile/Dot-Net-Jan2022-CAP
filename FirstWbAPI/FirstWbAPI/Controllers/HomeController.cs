using FirstWbAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWbAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        static List<Student> studentList = new List<Student>();
        [Route("getstudentdata")]
        [HttpGet]
        public List<Student> Get()
        {

            //var student1 = new Student();
            //student1.StudentId = 1;
            //student1.StudentName = "Vikash Verma 1";
            //studentList.Add(student1);
            //var student2 = new Student();
            //student2.StudentId = 2;
            //student2.StudentName = "Vikash Verma 2";
            //studentList.Add(student2);
            return studentList;
        }

        [Route("RecieveStudentData")]
        [Consumes("application/x-www-form-urlencoded")]
        [HttpPost]
        public void RecieveStudentData([FromForm] Student studentdata)
        {
            studentList.Add(studentdata);
        }


        //[Route("poststudentdata")]
        //[Consumes("application/x-www-form-urlencoded")]
        //[HttpPost]
        //public Student PostStudentData([FromForm] Student studentdata) {

        //    return studentdata;


        //}
        //[HttpPost]
        //[Route("postsample")]
        //public string sampledata([FromBody]string sample)
        //{
        //    return sample;
        //}


    }
}
