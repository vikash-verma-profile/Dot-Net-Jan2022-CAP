using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Parse
    {
        static void Main12()
        {

            string sampleNumber = "20";
            int Number = int.Parse(sampleNumber);
            int ParsedNumber;
            int.TryParse("sasd",out ParsedNumber);
            Console.WriteLine(ParsedNumber);
        }
    }
}
