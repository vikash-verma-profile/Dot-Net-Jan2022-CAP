using System;
using System.Collections.Generic;
using System.Text;

namespace _2DataTypesAndArray
{
    class Class1{
    }

    class Class2
    {
    }
    class ISAndAS
    {
        public static void Test(object Obj)
        {
            //is operator
            if (Obj is Class1)
            {
                Console.WriteLine("Object is of class 1");

            }
            else if (Obj is Class2)
            {
                Console.WriteLine("Object is of class 2");
            }
            else
            {
                Console.WriteLine("obj is neither class1 not class2");
            }
        }
        public static void Main(string[] args)
        {
            // created class 1 object
            Class1 c1 = new Class1();
            // created class 2 object
            Class2 c2 = new Class2();

            Test(c1);
            Test(c2);
            //checked with passing some dummy value also
            Test("Pass som test value");
        }
    }
}
