using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConecpts
{
    class LocalInstanvariables
    {
        //local static instance variable
        public int sampleInstanceVariable;
        public void display()
        {
            int localVal = 5;
            Console.WriteLine(localVal);
        }
        static void Main6(string[] args)
        {
            LocalInstanvariables Obj1 = new LocalInstanvariables();
            Obj1.sampleInstanceVariable = 5;
            LocalInstanvariables Obj2 = new LocalInstanvariables();
            Obj2.sampleInstanceVariable = 6;
            Console.WriteLine(Obj1.sampleInstanceVariable);
            Console.WriteLine(Obj2.sampleInstanceVariable);
            Obj1.display();
            Obj2.display();
        }
    }
}
