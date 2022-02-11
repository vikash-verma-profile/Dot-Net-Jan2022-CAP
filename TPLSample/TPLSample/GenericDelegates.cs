using System;
using System.Collections.Generic;
using System.Text;

namespace TPLSample
{

    internal class GenericDelegates
    {
        //10
        public static double AddNumber1(int no1,float no2,double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length>5)
            {
                return true;

            }
            return false;
        }
        public static void Main()
        {
            Func<int, float, double, double> obj1 = new Func<int, float, double, double>(AddNumber1);
            double Result = obj1.Invoke(100, 123.45f, 546.789);
            Console.WriteLine(Result);
            Action<int, float, double> obj2 = new Action<int, float, double>(AddNumber2);
            obj2.Invoke(50, 255.45f, 123.898);
            Predicate<string> Obj3 = new Predicate<string>(CheckLength);
            bool status = Obj3.Invoke("Vikash");
            Console.WriteLine(status);
        }
    }
}
