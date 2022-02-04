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
        public string Name { get; set; }
    }
    class Properties
    {
        public static void Main4()
        {
            Student objStudent = new Student();
            objStudent.Name = "Value";
            Console.WriteLine(objStudent.RollNumber);
            Console.WriteLine(objStudent.Name);
        }

    }
}
