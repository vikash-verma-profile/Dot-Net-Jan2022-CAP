using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemos
{
    //aggregation operators

    //aggregate
    //average
    //count
    //longcount
    //max
    //min
    //sum
    class Class8
    {
        static void Main()
        {
            IList<string> strList = new List<string>() { "one", "two", "three", "four" };
            var commasepartedstring = strList.Aggregate((s1, s2) => s1 + " | " + s2);
            Console.WriteLine(commasepartedstring);
        }
    }
}
