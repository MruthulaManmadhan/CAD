using System;

namespace ShapesOOPs
{
    class Program
    {
        abstract class Shape
        {
            public string colour { get; set; }
            public abstract void Area();
            public abstract void Perimeter();

        }
        class Rectangle : Shape
        {
            public int Length { get; set; }
            public int Breadth { get; set; }
            public override void Area()
            {
                Console.WriteLine("Area of Rectangle is : {0}", Length * Breadth);
            }
            public override void Perimeter()
            {
                Console.WriteLine("Perimeter of Rectangle is : {0}", 2 * (Length + Breadth));
            }
            public Rectangle(int length,int breadth)
            {
                Length = length;
                Breadth = breadth;
            }
        }
        class Square:Shape
        {
            public int Side { get; set; }
            public override void Area()
            {
                Console.WriteLine("Area of Square is : {0}",Side*Side);
            }
            public override void Perimeter()
            {
                Console.WriteLine("Perimeter of Square is : {0}",Side*4);
            }
            public Square(int side)
            {
                Side = side;
            }

        }
        class Circle:Shape
        {
            public int Radius;
            public override void Area()
            {
                Console.WriteLine("Area of Circle is : {0}", 3.14*Radius*Radius);
            }
            public override void Perimeter()
            {
                Console.WriteLine("Perimeter of Circle is : {0}",2*3.14*Radius);
            }
            public Circle(int radius)
            {
                Radius = radius;
            }
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 4);
            rectangle.Area();
            rectangle.Perimeter();
            Square square = new Square(3);
            square.Area();
            square.Perimeter();
            Circle circle = new Circle(5);
            circle.Area();
            circle.Perimeter();
            Console.ReadLine();
        }
    }
}
