using ShapesAndCircle;
using System;
using System.Collections.Generic;
using System.Text;

namespace RectangularAndSphere
{
    public class Rectangle : IShapes
    {
        int length { get; set; }
        int breadth { get; set; }
        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }
        public virtual void Display()
        {
            Console.WriteLine("It's Rectangle");
        }
        public void Perimeter()
        {
            Console.WriteLine("Perimeter is {0}", 2 * (length + breadth));
        }
    }
}
