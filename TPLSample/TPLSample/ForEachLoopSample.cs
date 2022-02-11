using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLSample
{
    internal class ForEachLoopSample
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Foreach loop");

            List<int> integerList = Enumerable.Range(1, 10).ToList();
            foreach (var item in integerList)
            {
                long total = DoSomethingtoConsumeTime();
                Console.WriteLine("{0} - {1}", item, total);
            }

            //Parallel.ForEach(integerList, i =>
            //{
            //    long total = DoSomethingtoConsumeTime();
            //    Console.WriteLine("{0} - {1}", i, total);
            //});
            DateTime Enddattime=DateTime.Now;
            TimeSpan span = Enddattime - dateTime;
            int ms = (int)span.TotalMilliseconds;
            Console.WriteLine("Time taken in miliseconds "+ms);
        }

        static long DoSomethingtoConsumeTime()
        {
            long total = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
