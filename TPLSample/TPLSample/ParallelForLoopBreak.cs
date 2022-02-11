using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLSample
{
    internal class ParallelForLoopBreak
    {
        static void Main2(string[] args)
        {

            var BreakSource=Enumerable.Range(0, 1000).ToList();
            int BreakData = 0;
            Console.WriteLine("Using loopstate ");
            Parallel.For(0, BreakSource.Count, (i, BreakLoopState) => {
                BreakData += i;
                if (BreakData > 100)
                {
                    BreakLoopState.Break();
                    Console.WriteLine("Break Called iteration {0} data ={1}",i,BreakData);
                }
            });
            Console.WriteLine("BreakData Called data ={0}",BreakData);
        }
    }
}
