using System;
using System.Collections.Generic;
using System.Text;

namespace TPLSample
{

    public class AnonymousMethods
    {

        public delegate string GreetDelegate(string name);
        //public static string Greet(string name)
        //{
        //    return "Hello " + name;
        //}
        //8
        static void Main(string[] args)
        {
            String Message = "HEY !";
            //GreetDelegate gd = new GreetDelegate(AnonymousMethods.Greet);
            GreetDelegate gd = delegate (string name)
            {
                return "Hello " + name+ Message;
            };
            Console.WriteLine(gd.Invoke("Vikash Verma"));
        }
    }
}
