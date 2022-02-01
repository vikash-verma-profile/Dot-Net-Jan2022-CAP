using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NullableTypes
    {
        static void Main11()
        {
            Nullable<int> num = null;
            int? number2 = null;

            //string and stringBuilder
            string sample = "vikash";
            sample = "verma";

            sample=sample.Replace("verma","Vikash Verma");
            var result=sample.Contains("vikash");
            //Index of
            string sa = "1,2,3,4";
            var splitdata =sa.Split(',');
            for (int i = 0; i < splitdata.Length; i++)
            {
                Console.WriteLine(splitdata[i]);
            }
            StringBuilder s = new StringBuilder();
            s.Append("asdasd");
            s.Replace("asdasd","Hi i am a stringBuilder Example");
            
        }
    }
}
