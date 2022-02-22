using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemos
{
    class Class5
    {
        //groupby
        //tolookup

        static void Main()
        {
            IList<Student> sampleList = new List<Student>() {
                new Student { StudentId = 1, Age = 18, StudentName = "John" },
                new Student { StudentId = 2, Age = 21, StudentName = "Bill" },
                new Student { StudentId = 3, Age = 21, StudentName = "Ram" },
                new Student { StudentId = 4, Age = 18, StudentName = "Ravi" },
                new Student { StudentId = 5, Age = 21, StudentName = "Rob" },
                new Student { StudentId = 6, Age = 18, StudentName = "Kumar" }
            };

            //var groupedResult = from s in sampleList group s by s.Age;

            var groupedResult = sampleList.GroupBy(s=>s.Age);
            var lookupResult = sampleList.ToLookup(s => s.Age);

            //foreach (var item in groupedResult)
            //{
            //    Console.WriteLine("Age group  "+item.Key); //Each group Key
            //    foreach (var student in item)
            //    {
            //        Console.WriteLine("Student Name  " + student.StudentName); 
            //    }
            //}

            foreach (var item in lookupResult)
            {
                Console.WriteLine("Age group  " + item.Key); //Each group Key
                foreach (var student in item)
                {
                    Console.WriteLine("Student Name  " + student.StudentName);
                }
            }

        }
    }
}
