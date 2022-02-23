using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SampleContext();

            //--for insertion
            //EmployeeDetail emp = new EmployeeDetail();
            //emp.Gender = "Male";
            //emp.Employeename = "Vikash";
            //emp.Salary = 10000;
            //context.EmployeeDetails.Add(emp);
            //context.SaveChanges();


            //--for updation

            //var employeeData = context.EmployeeDetails.Where(x => x.Id == 1).FirstOrDefault();
            //employeeData.Gender = "Female";
            //employeeData.Employeename = "Kumari";
            //context.EmployeeDetails.Update(employeeData);
            //context.Entry(employeeData).State = EntityState.Modified;
            //context.SaveChanges();

            //--for delete
            var employeeData = context.EmployeeDetails.Where(x => x.Id == 1).FirstOrDefault();
            context.EmployeeDetails.Remove(employeeData);
            context.SaveChanges();
            var data = context.EmployeeDetails.ToArray();
            foreach (var item in data)
            {
                Console.WriteLine(item.Gender);
                Console.WriteLine(item.Employeename);
                Console.WriteLine("===========");
            }
            Console.ReadLine();
           
        }
    }
}
