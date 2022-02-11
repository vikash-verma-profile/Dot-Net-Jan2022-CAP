using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPLSample
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("C# for loop");
            int number = 10;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"value of count={i},{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }

            Console.WriteLine();
            Console.WriteLine("Parallel For loop");

            Parallel.For(0, number, i =>
            {
                Console.WriteLine($"value of count={i}, {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            });
            Console.ReadLine();
        }
    }
}
