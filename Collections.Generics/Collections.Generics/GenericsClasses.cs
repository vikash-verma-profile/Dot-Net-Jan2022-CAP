using System;
using System.Collections.Generic;
using System.Text;
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

            Hashtable ht=new Hashtable();
            ht.Add("vb","vb.net");
            ht.Add("cs", "cs.net");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            //DictionaryEntry is a class whose object represents the data in a combination of key and value
            
            SortedList Sl =new SortedList();
            Stack s=new Stack();
            Queue q=new Queue();
        }
    }
}
