using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemos
{
    delegate bool FindStudent(Student std);

    class StudentExtension
    {
        public static Student[] where (Student[] stdArray,FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach (var item in stdArray)
            {
                if (del(item))
                {
                    result[i] = item;
                    i++;
                }
            }
            return result;
        }
    }
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
    class Class2
    {
        static void Main(string[] args)
        {
            Student[] studentsArray = {
                new Student { StudentId = 1, Age = 18, StudentName = "John" },
                new Student { StudentId = 6, Age = 19, StudentName = "Kumar" },
                new Student { StudentId = 2, Age = 21, StudentName = "Bill" },
                new Student { StudentId = 3, Age = 20, StudentName = "Ram" },
                new Student { StudentId = 4, Age = 25, StudentName = "Ravi" },
                new Student { StudentId = 5, Age = 31, StudentName = "Rob" }
            };

            //Student[] students = new Student[10];
            //int i = 0;

            //foreach (var item in studentsArray)
            //{
            //    if(item.Age>12 && item.Age < 20)
            //    {
            //        students[i] = item;
            //        i++;
            //    }
            //}

            //Linq to find teenager students

            Student[] teenagerstudent = studentsArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();


            //find the student have name bill
            Student bill = studentsArray.Where(s =>s.StudentName=="Bill").FirstOrDefault();

            foreach (var item in teenagerstudent)
            {
                Console.WriteLine(item.StudentId+" "+ item.Age+" "+ item.StudentName);
            }
            Console.WriteLine("================================================");

            Console.WriteLine(bill.StudentId + " " + bill.Age + " " + bill.StudentName);
        }
    }
}
