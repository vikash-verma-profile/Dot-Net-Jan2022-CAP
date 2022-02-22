using System;
using System.Linq;

namespace LinqDemos
{
    class Program
    {
        static void Main1(string[] args)
        {
           // Console.WriteLine("Hello World!");
            string[] names = { "Bill", "James", "Mohan", "Ravi" };

             var linqquery = from name in names where name.Contains('a') select name;
            //var linqquery = from name in names select name;

            foreach (var item in linqquery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
