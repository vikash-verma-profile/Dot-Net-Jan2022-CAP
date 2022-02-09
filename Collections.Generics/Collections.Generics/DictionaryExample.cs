using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Generics
{
    internal class DictionaryExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of Dictionary");
            Dictionary<int, string> PL = new Dictionary<int, string>();
            Console.WriteLine("Please enter name of languages");
            for(int i = 1; i < 3; i++)
            {
               PL.Add(i,Console.ReadLine());
            }
            foreach (var item in PL)
            {
                Console.WriteLine(item.Key+"====>"+item.Value);
            }
            
        }
    }
}
