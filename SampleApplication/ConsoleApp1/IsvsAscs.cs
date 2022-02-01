using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class A
    {

    }
    class IsvsAscs
    {
        
        static void Main()
        {
            A a1 = new A();
            Console.WriteLine(a1 is A);
            object[] o = new object[2];
            o[0] = 45;
            o[1] = "sample";

            string sample = o[1] as string;
            Console.WriteLine(sample);
        }
    }
}
