using System;
using System.Collections.Generic;

namespace Collections.Generics
{

    //Dictionary<key,value>
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("================Dictionary============");

            Dictionary<int,string> keyValues = new Dictionary<int,string>();
            keyValues.Add(1, "Dot NET");
            keyValues.Add(2, "JAVA");
            keyValues.Add(3, "PHP");
            keyValues.Add(4, "SQL");

            foreach (var item in keyValues)
            {
                Console.WriteLine(item.Key+"==>"+item.Value);
            }
            Console.WriteLine("================List============");

            List<string>  Names=new List<string>();
            Names.Add("Vikash");
            Names.Add("Sumit");
            Names.Add("Rajan");
            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================SortedList============");

            SortedList<string,string> sl=new SortedList<string,string>();
            sl.Add("ora","oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");

            foreach (var item in sl)
            {
                Console.WriteLine(item.Key + "==>" + item.Value);
            }
            Console.WriteLine("================Stack============");
            Stack<string> st = new Stack<string>();
            st.Push("oracle");
            st.Push("vb.net");
            st.Push("cs.net");

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("================Queue============");
            Queue<string> q = new Queue<string>();
            q.Enqueue("oracle");
            q.Enqueue("vb.net");
            q.Enqueue("cs.net");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
