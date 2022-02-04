using System;

namespace SeleadClass
{
    //sealed

    sealed class A
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class B
    {

    }
    class Program
    {
        static void Main1(string[] args)
        {

            string s1 = "test";
            string s2= "test";
            string s3 = "test1".Substring(0, 4);
            object s4 = s3;
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine(s1.Equals(s4));
            Console.WriteLine("==============================");
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 == s3);
            Console.WriteLine(s1 == s4);
            Console.WriteLine("==============================");
            Console.WriteLine(object.ReferenceEquals(s1,s2));
            Console.WriteLine(object.ReferenceEquals(s1, s3));
            Console.WriteLine(object.ReferenceEquals(s1, s4));
            //A a=new A();
            //int c=a.Add(1,2);
            //Console.WriteLine("Add :{0}",c);

            const int a = 5;
            int b = 6;
        }
    }
}
