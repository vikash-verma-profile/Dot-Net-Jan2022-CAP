using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConecpts
{
    class NormalParms
    {
        static int Sum(params int[]param1)
        {
            int val = 0;
            foreach (var item in param1)
            {
                val = val + item;
            }
            return val;
        }
        static void Main8(string[] args)
        {
         
            Console.WriteLine(Sum());
        }
    }
}
