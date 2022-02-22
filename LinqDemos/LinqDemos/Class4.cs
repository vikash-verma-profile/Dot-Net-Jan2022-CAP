using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemos
{
    class Class4
    {
        //order by 
        //orderby descending
        //thenby
        //thenby descending
        static void Main()
        {

            IList<Student> sampleList = new List<Student>() { 
                new Student { StudentId = 1, Age = 18, StudentName = "John" },
                new Student { StudentId = 2, Age = 21, StudentName = "Bill" },
                new Student { StudentId = 3, Age = 20, StudentName = "Ram" },
                new Student { StudentId = 4, Age = 25, StudentName = "Ravi" },
                new Student { StudentId = 5, Age = 31, StudentName = "Rob" },
                new Student { StudentId = 6, Age = 19, StudentName = "Kumar" }
            };

            var orderByResult = from s in sampleList orderby s.StudentName select s;

            var orderByDescendigResult= from s in sampleList orderby s.StudentName descending select s;

            var studentsinascOrder = sampleList.OrderBy(s => s.StudentName);
            var studentsindescOrder = sampleList.OrderByDescending(s => s.StudentName);
            var ThenByOrder = sampleList.OrderBy(s => s.StudentName).ThenBy(s=>s.Age);
            var ThenByOrderDescResult = sampleList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
        }

    }
}
