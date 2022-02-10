using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Threading
{
    internal class ExampleofThreadJoin
    {
        static void Main2(string[] args)
        {
            //Thread thread = new Thread(MethodJoin);
            //Console.WriteLine(thread.ThreadState);
            //thread.Start();
            //Console.WriteLine(thread.ThreadState);
            //thread.Join();
            //Console.WriteLine(thread.ThreadState);
            //Console.WriteLine("Work completed");

            Stopwatch stwatch = new Stopwatch();
            stwatch.Start();

            Thread oThread = new Thread(ProcessSleep);
            oThread.Start();
            oThread.Join();
            stwatch.Stop(); 
            TimeSpan ts=stwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",ts.Hours,ts.Minutes,ts.Seconds);
            Console.WriteLine(elapsedTime);
            Console.WriteLine("WOrk completed");
        }

        static void MethodJoin()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work in progress");
            }
        }
        static void ProcessSleep()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work in progress");
                Thread.Sleep(4000);//4 second
            }
        }
    }
}
