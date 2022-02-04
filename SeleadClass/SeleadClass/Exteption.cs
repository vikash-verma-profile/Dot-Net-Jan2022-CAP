using System;
using System.Collections.Generic;
using System.Text;

namespace SeleadClass
{

    class Exteption
    {
        public static void Main()
        {
            try
            {
                int a = 0;
                var s = 8 / a;
                int[] ar = new int[2];
                Console.WriteLine(ar[3]);
            }
            catch (IndexOutOfRangeException ex1)
            {
                Console.WriteLine("out of bound"+ex1.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("divide by 0 "+ex.Message);
            }


            Console.WriteLine();
        }
    }
}
