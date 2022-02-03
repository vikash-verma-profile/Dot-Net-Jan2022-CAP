using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLeftOvers
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void setAge(int _age)
        {
            age = _age;
        }
    }
    class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying ");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is "+age);
        }
    }
    class ProblemStatement1
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.setAge(21);
            student.Greet();
            student.ShowAge();
            Teacher teacher = new Teacher();
            teacher.setAge(40);
            teacher.Greet();
            teacher.Explain();
            Console.ReadLine();

            
        }
    }
}
