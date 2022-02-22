using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemos
{
    class Class9
    {
        //first
        //firstorDefault
        //last
        //lastordefault
        public static void Main()
        {
            IList<int> intlist = new List<int>() { 7, 10, 21, 30 };
            IList<string> strlist = new List<string>() { null, "two", "Three", "Four" };
            IList<string> emptylist = new List<string>() ;

            var sample = emptylist.DefaultIfEmpty("None");
            sample= sample.DefaultIfEmpty("None 1");
            Console.WriteLine(sample.Count());
            //var collection3 = strlist.Concat(emptylist);

            Console.WriteLine(intlist.First());
            Console.WriteLine(intlist.First(i=>i%2==0));
            Console.WriteLine(strlist.First());
            Console.WriteLine(emptylist.FirstOrDefault());

        }
    }
}
