using System;
using System.Collections.Generic;
using System.Text;

namespace TPLSample
{
    internal class LambdaExpression
    {
        public delegate string GreetDelegate(string name);
        //9
        static void Main9(string[] args)
        {
            String Message = "HEY !";
            GreetDelegate gd = (name)=>
            {
                return "Hello " + name + Message;
            };
            Console.WriteLine(gd.Invoke("Vikash Verma"));
        }
    }
}
