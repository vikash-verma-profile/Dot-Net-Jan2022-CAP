using System;
using System.Collections.Generic;
using System.Text;

namespace TPLSample
{

    //access modifier delegate <return type> <degate name> (argument list)

    public delegate void AddDelegate(int a,int b);
    public delegate string GreetDelegate(string name);
    internal class Delegarteexample
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static string Greet(string name)
        {
            return "Hello "+name;

        }
        static void Main4(string[] args)
        {
            //class object
            Delegarteexample obj =new Delegarteexample();
            //Delgate instialization
            AddDelegate ad = new AddDelegate(obj.Add);


            GreetDelegate gd = new GreetDelegate(Delegarteexample.Greet);
            ad(100,50);
            Console.WriteLine(gd("Vikash"));
        }
    }
}
