using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConecpts
{

    class StaticSample
    {
        static StaticSample()
        {

        }
        public static string a="Sample";
    }
    class StaticKeyword
    {
        //Static is a modifier in c# which we can use with
        //1.class
        //2.variable
        //3.Method
        //4/Constructor

        /*
         * if you create a class as static then you cannot create instance of 
        that class
        2.we cannot create non-static memebers
        3.you cannot inhetit the class


        */
        static void Main3(string[] args)
        {
            StaticSample staticSample = new StaticSample();
            StaticSample.a = "3";
            
            Console.WriteLine(StaticSample.a);

        }
    }
}
