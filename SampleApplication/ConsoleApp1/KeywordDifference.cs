using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class KeywordDifference
    {
        //ref vs out
        //const vs readonly
        //var vs dynamic
        //boxing and unboxing
        //type conversion
        static void Main6()
        {
            int a = 2;
            int b = 10;
            //boxing
            object obj = a;
            Console.WriteLine(obj);
            //unboxing
            //type casting
            a = (int)obj;
            Console.WriteLine(a);

            b=Convert.ToInt32("2");
            b.ToString();
            Convert.ToString(b);
            
            Console.WriteLine(b);
        }
    }
}
