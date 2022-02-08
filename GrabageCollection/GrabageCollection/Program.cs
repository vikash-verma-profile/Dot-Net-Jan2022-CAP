using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace GrabageCollection
{
    internal class Program
    {
        Program()
        {
            
        }
        ~Program()
        {
            Console.WriteLine("Finalize ovveriden");
            //forcefully stop grabage collector to invoke the finialize method by calling this metho
            GC.SuppressFinalize(this);
        }
        //protected override void Finalize()
        //{
        //    Console.WriteLine("Finalize ovveriden");
        //}
        static void Main(string[] args)
        {
            
            Console.WriteLine("the generation are " + GC.GetTotalMemory(false));
            /*
            Program p=new Program();
            Console.WriteLine("the generation are " +GC.MaxGeneration);
            Console.WriteLine("the generation are " + GC.GetGeneration(p));
            Console.WriteLine("the generation are " + GC.GetTotalMemory(false));
            */
            //for collection of grabage 
            //gc.collect

            //GC.Collect();
            //Console.WriteLine("GC in generation 0 {0}",GC.CollectionCount(0));
            finally
            {
                
            }

        }
    }
}
