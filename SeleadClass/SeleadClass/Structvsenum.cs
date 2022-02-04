using System;
using System.Collections.Generic;
using System.Text;

namespace SeleadClass
{
    //structure and enum
    //homogenous
    //hetrogenous
    //structure is value type
    //class is refernce type


    //structure can have
    /*Fields
     * Parametrized constructor
     * constants
     * properties
     * indexers
     * events
     * methods
     */ 
    public struct Person
    {
        public string Name;
        public int Age;
        public int Weight;
    }
    class Structvsenum
    {
        public static void Main()
        {
            Person person;
            person.Name = "Sameer";
            person.Age = 21;
            person.Weight = 70;

            Console.WriteLine("Data is stored in person Name:" + person.Name);
            Console.WriteLine("Data is stored in person Age:" + person.Age);
            Console.WriteLine("Data is stored in person Weight" + person.Weight);
        }
    }
}
