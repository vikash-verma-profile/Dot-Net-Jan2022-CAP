using System;
using System.Collections;

namespace Collections.Generics
{
    internal class GenericsClasses
    {
        //Non -generic

        //
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //string str = "sample";
            //int x = 7;
            //DateTime dt = DateTime.Now;

            //al.Add(x);
            //al.Add((DateTime)dt);
            //al.Add(str);

            //foreach (var item in al)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable is similar to arraylist but represents the items as a combination of a key and a value

            //Hashtable ht=new Hashtable();
            //ht.Add("vb","vb.net");
            //ht.Add("cs", "cs.net");
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            //DictionaryEntry is a class whose object represents the data in a combination of key and value
            

            //its a class that has combintaion of arraylist and hashtable

            SortedList Sl =new SortedList();

            Sl.Add("1","JAVA");
            Sl.Add("2", "C#");
            Sl.Add("3", "C++");
            //Sl.Capacity==> Capacity is the number of elements that we can have in sortedlist
            //Sl.Count ==> count is the number of elemnets we have
            //clear()
            //containsvalue()
            //containskey()
            foreach (DictionaryEntry item in Sl)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }


            //LIFO
            Stack s=new Stack();
            s.Push("1");
            s.Push("2");
            s.Push("3");

            foreach (object item in s)
            {
                Console.WriteLine(item);
            }
            //FIFO
            Queue q=new Queue();
            q.Enqueue("1");
            q.Enqueue("2");
            q.Enqueue("3");
            foreach (object item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
