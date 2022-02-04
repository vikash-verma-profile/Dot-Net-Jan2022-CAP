using System;
using System.Collections.Generic;
using System.Text;

namespace SeleadClass
{

    public static class sample
    {
        public static void NewMethod(this Class1 ob)
        {
            Console.WriteLine("Hello I am a extended Method");
        }
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str);
        }
        public static string[] ConvertCommaSepartedValue(this string str)
        {
            return str.Split(',');
        }
    }
    class ExtensionMethodDemo
    {
        public static void Main()
        {
            Class1 ob = new Class1();
            Console.WriteLine(ob.Display());
            string []sample = "1,2,3".ConvertCommaSepartedValue();
            foreach (var item in sample)
            {
                Console.WriteLine(item);
            }
        }
    }
}
