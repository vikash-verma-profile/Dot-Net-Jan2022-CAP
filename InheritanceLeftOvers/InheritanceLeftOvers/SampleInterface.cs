using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLeftOvers
{
    interface IAnimal
    {
        void animalsound();
       // void run();
    }

    class Pig : IAnimal
    {
        public void animalsound()
        {
            Console.WriteLine("The pig says wee wee");
        }
    }
    class SampleInterface
    {

        public static void Main8()
        {
            Pig pig = new Pig();
            pig.animalsound();
        }
        
    }
}
