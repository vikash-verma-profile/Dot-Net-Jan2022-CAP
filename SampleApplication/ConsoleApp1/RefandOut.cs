using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RefandOut
    {
        static void Main10()
        {
            int b=1,c;
            sumref(ref b);
            sumout(b,out c);
        }

        static void sumref(ref int a)
        {

        }
        static void sumout(int a,out int result)
        {
            result = 1;
        }
    }
}
