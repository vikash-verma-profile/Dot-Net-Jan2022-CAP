using System;

namespace OopsConcepts
{
    class Program
    {
        static void Main1(string[] args)
        {

            string sampleString = "Demo class";

            object obj = sampleString;
            //As operator
            string str2 = obj as string;
            //type casting
            // boxing and unboxing
            //Created an object 
            //object -->string
            //
            if (str2!=null)
            {
                Console.WriteLine("Successfully casted");
                Console.WriteLine(str2);
            }
          
        }
    }
}
