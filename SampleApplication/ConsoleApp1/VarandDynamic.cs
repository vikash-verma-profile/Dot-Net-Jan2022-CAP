using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VarandDynamic
    {
        static void Main7()
        {
            //var is your compile time
            //dynamic is your runtime
            var a = 6;
            a =Convert.ToInt32("2");
            Console.WriteLine(a);
        }
    }
}
