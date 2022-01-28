using System;

namespace FisrtConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int Number=Convert.ToInt32(Console.ReadLine());
            switch(Number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Please give correct Input");
                    break;

            }



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            int y = 1;
            while (y < 5)
            {
                Console.WriteLine(y);
                y++;
            }
            int z = 1;
            do
            {
                Console.WriteLine(z);
                z++;
            } while (z<5);
            Console.WriteLine();
        }
    }
}
