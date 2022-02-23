using EFCodeFirst.Models;
using System;
using System.Linq;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What you want to do:- \n 1.Add \n 2.Delete");

            int choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter student name");
                    var studentName = Console.ReadLine();
                    using (var context = new SchoolContext())
                    {
                        var std = new Student() { Name = studentName };
                        context.Students.Add(std);
                        context.SaveChanges();

                    }
                    break;

                case 2:
                    Console.WriteLine("Which student data you want to delete.Please select Id from below");

                    using (var context = new SchoolContext())
                    {

                        var data = context.Students.ToList();
                        foreach (var item in data)
                        {
                            Console.WriteLine(item.StudentId + " : " + item.Name);
                        }

                    }
                    var StudentID = Convert.ToInt32(Console.ReadLine());
                    using (var context = new SchoolContext())
                    {
                        var StudentData=context.Students.Where(x => x.StudentId == StudentID).FirstOrDefault();
                        context.Students.Remove(StudentData);
                        context.SaveChanges();

                    }
                    break;
            }
         

            Console.WriteLine("Your operation is compelete !!");
        }
    }
}
