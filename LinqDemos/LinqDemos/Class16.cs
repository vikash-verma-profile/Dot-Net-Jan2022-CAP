using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemos
{
    //Join and Group Join
    //join is not join that we do--inner join in sql
    //group join is left outer join in sql

    class StudentStandard
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StandardId { get; set; }
    }
    class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
    class Class16
    {
        static void Main()
        {
            IList<string> strList1 = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four"
            };
            IList<string> strList2 = new List<string>()
            {
                "One",
                "Two",
                "Five",
                "Six"
            };

            var innerjoin = strList1.Join(strList2, str1 => str1, str2 => str2, (str1, str2) => str1);
            //foreach (var item in innerjoin)
            //{
            //    Console.WriteLine(item);
            //}

            IList<StudentStandard> StudentList = new List<StudentStandard>() {
                new StudentStandard { StudentId = 1, StandardId = 1, StudentName = "John" },
                new StudentStandard { StudentId = 2, StandardId = 1, StudentName = "Bill" },
                new StudentStandard { StudentId = 3, StandardId = 2, StudentName = "Ram" },
                new StudentStandard { StudentId = 4, StandardId = 2, StudentName = "Ravi" },
                new StudentStandard { StudentId = 5, StandardId = 1, StudentName = "Rob" },
            };

            IList<Standard> StandardList = new List<Standard>() {
                new Standard { StandardId = 1, StandardName = "Standard 1" },
                new Standard { StandardId = 2, StandardName = "Standard 2" },
                new Standard {  StandardId = 3, StandardName = "Standard 3" },
            };

            var innerJoinStandard = StudentList.Join(
                StandardList,
                student => student.StandardId,
                standard => standard.StandardId,
                (student, standard) => new
                {
                    StudentName = student.StudentName,
                    StandardName = standard.StandardName
                }
                );

            //foreach (var item in innerJoinStandard)
            //{
            //    Console.WriteLine(item.StandardName+" "+item.StudentName);

            //}

            var innerjoinQuery = from s in StudentList
                                 join st in StandardList
           on s.StandardId equals st.StandardId
                                 select new
                                 {
                                     StudentName = s.StudentName,
                                     StandardName = st.StandardName
                                 };

            var groupjoin = StandardList.GroupJoin(StudentList, std => std.StandardId, s => s.StudentId,
            (std,studentGroup)=>new 
            {
                Students=studentGroup,
                StandardFullName=std.StandardName
            }
            );

            foreach (var item in groupjoin)
            {
                Console.WriteLine(item.StandardFullName);
                foreach (var student in item.Students)
                {
                    Console.WriteLine(student.StudentName);
                }

            }

        }
    }
}
