using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExceptionHandling
{
    public class HandleIntegerFormat : Exception
    {
        public HandleIntegerFormat(string message) : base(message)
        {

        }
    }
    internal class HandlingRegex
    {
        static void Main(string[] args)
        {
            //this will return any pattern line ab,aab,aaab;
            //Regex re = new Regex("a+b");
            //this will return pattern like b, ab
            //Regex re = new Regex("a?b");
            Regex re = new Regex("^[A-Z]{5}$");


            Match match = re.Match("asdas7657657asd");
            if (match.Success)
            {
                Console.WriteLine("Mached the value " + match.Value);
            }

            //Console.WriteLine("Please enter a number");
            //try
            //{
            //    int a = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{

            //}
           
            Console.WriteLine();
        }
    }
}
