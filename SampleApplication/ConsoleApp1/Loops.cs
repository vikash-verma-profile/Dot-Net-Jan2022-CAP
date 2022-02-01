using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Loops
    {
        static void Main(string[] args)
        {
            //1.for loop
            //2.while loop
            //3.do while loop
            Console.WriteLine("Output from for loop");
            // insilization block;expression block:increment/Decrement block
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+ "\t");
            }

            Console.WriteLine("\nOutput from while loop");
            //intial block 
            int j = 0;
            //while loop
            while (j<10)//expression block
            {
                Console.Write(j+"\t");
                j++;
                //increment/Decrement block
            }
            Console.WriteLine("\nOutput from do while loop");
            //intial block 
            int k = 0;
            //while loop
            do
            {
                Console.Write(k + "\t");
                k++;
                //increment/Decrement block
            } while (k < 10);//expression block
            Console.WriteLine();

            //logical operaters

            // && || and !
            if(5==5 && 5<6) //for && both conditions should return true
            {

            }
            if (5 == 5 || 5 < 6) //for || one conditions should return true
            {

            }
            //! -not 5!=6
        }
    }
}
