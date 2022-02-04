using System;
using System.Collections.Generic;
using System.Text;

namespace SeleadClass
{

    class Student
    {
        private int rn=5;
        private string name;

        public int RollNumber
        {
            get
            {
                return rn;
            }
            set
            {
                rn = value;
            }
        }
        public int Name { get; set; }
    }
    class Properties
    {
        public static void Main()
        {
            Student objStudent = new Student();
            Console.WriteLine(objStudent.RollNumber);
        }

    }
}
