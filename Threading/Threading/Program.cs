using System;
using System.Threading;

namespace Threading
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Thread th=Thread.CurrentThread;
            //Console.WriteLine(th);

            //example of asyncronous 
            Thread work1Thread = new Thread(Work1);
            Thread work2Thread = new Thread(Work2);
            work1Thread.Start();
            work2Thread.Start();    
            //example of syncronous 
            //Work1();
            //Console.WriteLine("=======================================");
            //Work2();
            Console.ReadLine();
        }
        static void Work1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work 1 is called"+i.ToString());
            }
           
        }
        static void Work2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work 2 is called" + i.ToString());
            }
        }
    }
}
