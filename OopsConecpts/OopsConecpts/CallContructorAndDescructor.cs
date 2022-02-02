using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OopsConecpts
{
    class CallContructorAndDescructor
    {
        CallContructorAndDescructor()
        {
            Debug.WriteLine("Constructor is getting called");
        }
        ~CallContructorAndDescructor()
        {
            Debug.WriteLine("Descructor is getting called");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            CallContructorAndDescructor s = new CallContructorAndDescructor();
            Console.WriteLine();
        }
    }
}
