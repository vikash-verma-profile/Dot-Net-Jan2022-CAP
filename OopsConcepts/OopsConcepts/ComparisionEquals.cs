using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    //== and equals
    class ComparisionEquals
    {
        static void Main4(string[] args)
        {
            string name = "vikash";
            string Myname = name;

            var doubleeql = (name == Myname);//true
            var eql = name.Equals(Myname);//true
            Console.WriteLine(doubleeql); 
            Console.WriteLine(eql);
            Console.WriteLine("====================================");
            object nameObj = "vikash";
            char[] values = {'v','i','k','a','s','h'};
            object myName = new string(values);
            var doubleeql2 = (nameObj == myName);//false
            var eql2 = nameObj.Equals(myName);//true
            Console.WriteLine(doubleeql2);
            Console.WriteLine(eql2);
        }
    }
}
