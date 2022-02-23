using EFCoreDemo.Models;
using System;
using System.Linq;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SampleContext();

            EmployeeDetail emp = new EmployeeDetail();
            emp.Gender = "Male";
            emp.Employeename = "Vikash";
            emp.Salary = 10000;
            context.EmployeeDetails.Add(emp);
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
