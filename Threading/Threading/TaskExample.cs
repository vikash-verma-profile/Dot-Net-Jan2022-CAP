using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    internal class TaskExample
    {
        static void Main8(string[] args)
        {
            Task t1 = new Task(PrintInformation);
            t1.Start();
            Console.WriteLine("Main Thread Completed");
            Console.ReadLine();
        }
        static void PrintInformation()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Value of i {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}
