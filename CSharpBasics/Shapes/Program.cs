using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.GetArea(2.2);
            circle.GetPerimeter(2.2);
            Rectangle rectangle = new Rectangle();
            rectangle.GetArea(2, 4);
            rectangle.GetPerimeter(2,4);
            Squre squre = new Squre();
            squre.GetArea(3);
            squre.GetPerimeter(3);
            Console.ReadLine();
        }
    }
    public enum colour
    {
        Coloured=1,
        Colourless =2
    }
    public abstract class Shapes
    {
        public void GetArea()
        {
            Console.WriteLine("Sorry no area");
        }
        public void GetPerimeter()
        {
            Console.WriteLine("Sorry no perimeter");
        }
        string Colour;
        public string ShapeColour
        {
            get
            {
                return Colour;
            }
            set
            {
                Colour = Enum.GetName(typeof(colour), value);
            }
        }
    }
    public class Circle:Shapes
    {
        static double Pi = 22 / 7;
        //ShapeColour=2;
        public void GetArea(double radius)
        {
            Console.WriteLine("Area of the circle is {0} and colour of Circle is {1}", Pi*radius*radius, ShapeColour);
        }
        public void GetPerimeter(double radius)
        {
            Console.WriteLine("Perimeter of circel is {0}",2*Pi*radius);
        }
    }
    public class Squre : Shapes
    {
        //ShapeColour=2;
        public void GetArea(int side)
        {
            Console.WriteLine("Area of the Squre is {0} and colour of Squre is {1}", side * side,ShapeColour);
        }
        public void GetPerimeter(int side)
        {
            Console.WriteLine("Perimeter of Squre is {0}", 4*side );
        }
    }
    public class Rectangle : Shapes
    {
        //ShapeColour=1;
        public void GetArea(int length,int breadth)
        {
            Console.WriteLine("Area of the Rectangle is {0} and colour of Rectangle is {1}", length*breadth, ShapeColour);
        }
        public void GetPerimeter(int length, int breadth)
        {
            Console.WriteLine("Perimeter of Rectangle is {0}", 2 *(length+breadth));
        }
    }
}
