using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemos
{
    class Class7
    {
        //all check all the elements in the collection
        //any check if any elements in the collection
        //contains
        static void Main7()
        {
            IList<Student> sampleList = new List<Student>() {
                new Student { StudentId = 1, Age = 18, StudentName = "John" },
                new Student { StudentId = 2, Age = 21, StudentName = "Bill" },
                new Student { StudentId = 3, Age = 21, StudentName = "Ram" },
                new Student { StudentId = 4, Age = 18, StudentName = "Ravi" },
                new Student { StudentId = 5, Age = 21, StudentName = "Rob" },
                new Student { StudentId = 6, Age = 18, StudentName = "Kumar" }
            };

            bool allStudents = sampleList.All(s => s.Age > 12 && s.Age < 20);
            bool anyStudents = sampleList.Any(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(allStudents);
        }
    }
}
