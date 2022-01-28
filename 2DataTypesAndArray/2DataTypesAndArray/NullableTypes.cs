using System;
using System.Collections.Generic;
using System.Text;

namespace _2DataTypesAndArray
{
    class NullableTypes
    {
        public static void Main6(string[] args)
        {
            int? a = null;
            Nullable<int> b= null;
            Console.WriteLine(a);

            //var -compile time
            //dynamic- run time

            var sample = "vikash";//here you are telling to your complier that
                                  //make this as string type

            // sample = 1; //you are assiging a integer value

            dynamic dsample = "vikash";
            dsample = 1;
            //Console.WriteLine(dsample);

            //toString and Convert.tostring()

            int number = 45;
            object o = null;
            //string s = (o).ToString();
            string s = Convert.ToString(o);

            // what  is the differnce between out and ref

            int number2 = int.Parse("45");
            int number3;
            bool result=int.TryParse("95",out number3);
            Console.WriteLine(number3);
            Console.WriteLine(result);

            //create a program to check wheather the number is integer or not
        }
    }
}
