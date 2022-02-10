using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    internal class ForeGroundThread
    {
        static void Main4(string[] args)
        {
            Thread oThread = new Thread(WorkThread);
            oThread.Start();
            Console.WriteLine("Main Thread Quits");
        }

        static void WorkThread()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("WOrker Thread is in progress");
                Thread.Sleep(2000);//2 second
            }

            Console.WriteLine("Thread quits");
        }
    }
}
