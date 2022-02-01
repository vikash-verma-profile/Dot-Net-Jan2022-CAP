using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class valuevsreferencetype
    {

        //call by value and refence
        //functions
        static void Main2(string[] args)
        {
            //operator vs operand
            //+,-,%,*,%
            int a=10, b = 10;
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            //
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);

            //conditional statements

            //if else if else if switch 

            if (a == b)//equality operator
            {
                Console.WriteLine("a and b are equal");
            }
            else
            {
                Console.WriteLine("a and b are not equal");
            }
            //<= >=
            //create a program to check wether a number is odd or even
            //create a program to check wether a person whose age is 18.
            //if else and if
            //check number is postive,nagtiuce or whole number

            int ab= (a > 0) ? 7 : 15;
            Console.WriteLine(ab);
            a = 0;
            if(a>0)
            {
                Console.WriteLine("a is a postive number");
            }
            else if(a<0)
            {
                Console.WriteLine("a is a negative number");
            }
            else
            {
                Console.WriteLine("a is a whole number");
            }
            //Console.ReadLine();

            string choice;
            choice=Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You have chossen 1");
                    break;
                case "2": 
                    Console.WriteLine("You have chossen 2");
                    break;
                case "3":
                    Console.WriteLine("You have chossen 3");
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    break;
            }
            //iteration statements

            //1.for loop
            //2.while loop
            //3.do while loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
