using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLeftOvers
{

    class Shape
    {
        protected Location c;

        public string ToString()
        {
            return string.Empty;
        }

        public double Area()
        {
            return 0.000;
        }
        public double Parameter()
        {
            return 0.000;
        }
    }
    class Location
    {
        private double x, y;
    }
    class Circle
    {
        protected double radius;
    }
    class Rectangle
    {
        protected double side1, side2;
    }
    class ShapeProblem
    {
        
    }

}
