using System;
using System.Collections.Generic;
using System.Text;

namespace GrabageCollection
{
    class calculator
    {
        public int Add(int a,int b)
        {
            return (a + b);
        }
        public int Sub(int a, int b)
        {
            return (a - b);
        }
        public int Multi(int a, int b)
        {
            return (a * b);
        }
        public int Divide(int a, int b)
        {
            return (a / b);
        }

    }
    internal class CheckCollectionCount
    {
        static void Main1(string[] args)
        {
            calculator calculator = new calculator();   
            Console.WriteLine("Calculator object is now on "+GC.GetGeneration(calculator)+"Generation");
            Console.WriteLine("Grabage Collection Occured at 0th Generation " + GC.GetGeneration(0));
            Console.WriteLine("Grabage Collection Occured at 1th Generation " + GC.GetGeneration(1));
            Console.WriteLine("Grabage Collection Occured at 2th Generation " + GC.GetGeneration(2));
            GC.Collect(0);
            Console.WriteLine("Grabage Collection Occured at 0th Generation " + GC.GetGeneration(0));
        }
    }
}
