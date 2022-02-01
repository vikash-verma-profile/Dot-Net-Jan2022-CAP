using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FunctionParamters
    {
        //2 types
        //optional parameters
        //named parameters
        static void Main6()
        {
            DisplayValue(10, 20);
            DisplayNamedValue(c:10,a:20,b:30);
        }
        static void DisplayValue(int a,int b=40,int c=50)
        {
            Console.WriteLine("a={0},b={1},c={2}",a,b,c);
        }

        static void DisplayNamedValue(int a, int b, int c)
        {
            Console.WriteLine("a={0},b={1},c={2}", a, b, c);
        }
    }
}
