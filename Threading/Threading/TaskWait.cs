using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class TaskWait
    {
        public static void Main9()
        {
            Task t1 = Task.Run(() => { PrintInformation(); });
            t1.Wait();
            Console.WriteLine("Main Thread completed");

        }
        static void PrintInformation()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Value of i {0}", i);
            }
            Console.WriteLine("Child Thread completed");
        }
    }
}
