
using RectangularAndSphere;
using ShapesAndCircle;
using System;

namespace InterfaceIn2ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            IShapes circle = new Circle(2);
            circle.Display();
            circle.Perimeter();
            IShapes rectangle = new Rectangle(2,4);
            rectangle.Display();
            rectangle.Perimeter();
            IShapes squre = new Squre(5);
            squre.Perimeter();
            Console.ReadLine();
        }
    }
}
