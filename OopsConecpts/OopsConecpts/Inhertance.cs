using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConecpts
{

    //parent class
    public class Shape
    {
        protected int length;
        public Shape()
        {

        }
        public Shape(int _length)
        {
            length = _length;
        }
        public void Print()
        {
            Console.WriteLine("Length=" + length);
        }

    }
    //child class
    public class Circle : Shape
    {
        public Circle(int radius):base(radius)
        {

        }
        public void DisplayRadius()
        {
            Console.WriteLine("Radis of the circle is " + length);
        }
    }
    public class Triangle : Shape
    {
       public Triangle(int length) : base(length)
        {

        }
        public void DisplayLength()
        {
            Console.WriteLine(" side length" + length);
        }
    }
    class Inhertance
    {
        public static void Main11()
        {
            //Shape shape = new Shape();
            Shape Cshape = new Circle(7);
            Cshape.Print();

            Shape Tshape = new Triangle(8);
            Tshape.Print();

            // shape.DisplayRadius();
            Triangle t = new Triangle(10);
            t.DisplayLength();
            Console.ReadLine();
        }

    }
}
