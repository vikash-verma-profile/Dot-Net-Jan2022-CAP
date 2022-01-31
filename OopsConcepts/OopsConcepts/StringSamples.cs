using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    class StringSamples
    {
        static void Main(string[] args)
        {

            string s = "some value";
            s = "Vikash";
            //replace
            //split
            //startswith
            //substring
            //tolower
            //toupper
            s=s.Replace("Vikash", "1,2,3");
            var valuearray = s.Split(',');
            Console.WriteLine("Values after spliting");
            for (int i = 0; i < valuearray.Length; i++)
            {
                Console.WriteLine(valuearray[i]);
            }
            Console.WriteLine(s);
            StringBuilder sb = new StringBuilder("Hello world");
            sb.Append("Hello");
            sb.Replace("Hello","Hello 1");
            sb.Insert(0,"New value");
            Console.WriteLine(sb);
        }
    }
}
