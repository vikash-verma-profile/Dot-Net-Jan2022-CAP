using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConecpts
{

    //Base class
    class Vehicle //parent
    {
        public string brand="TATA";
        public void honk()
        {
            Console.WriteLine("Honk");
        }
    }
    class Car : Vehicle //child or derived class
    {
        public string modelname = "SAFARI";
    }
    class InheritanceSample
    {
        public static void Main()
        {
            Car car = new Car();
            car.honk();
            Console.WriteLine(car.brand+"  "+car.modelname);
        }
    }
}
