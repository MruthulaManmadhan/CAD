using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesAndCircle
{
    public class Circle : IShapes
    {
        double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public void Display()
        {
            Console.WriteLine("It's a Circle");
        }
        public void Perimeter()
        {
            Console.WriteLine("Perimeter of circle is {0}", Radius * Radius * Math.PI);
        }
    }
}
