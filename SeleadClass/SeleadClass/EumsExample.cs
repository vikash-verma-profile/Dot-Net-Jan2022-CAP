using System;
using System.Collections.Generic;
using System.Text;

namespace SeleadClass
{
    //enum is also value type

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thrusday,
        Friday,
        Saturday,
        Sunday
    }

    class Parimeter
    {
        public enum Shapes
        {
            circle,square
        }

        public void PrintParameter(int val, Shapes shapes)
        {
            if (shapes == 0)
            {
                Console.WriteLine("Circumference of circle" + 2 * 3.14 * val);
            }
            else
            {
                Console.WriteLine("Circumference of square" + 4 * val);

            }
        }
    }
   
    class EumsExample
    {
        public static void Main()
        {
            Console.WriteLine("Value of Monday is "+WeekDays.Monday);
            Console.WriteLine("Value of Monday is " + (int)WeekDays.Monday);
            Parimeter p = new Parimeter();
            p.PrintParameter(3,Parimeter.Shapes.circle);
            p.PrintParameter(5, Parimeter.Shapes.square);

        }
    }
}
