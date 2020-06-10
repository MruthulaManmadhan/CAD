using System;
using System.Collections.Generic;
using System.Text;

namespace RectangularAndSphere
{
    public class Squre : Rectangle
    {
        public Squre(int s) : base(s, s)
        {
            Console.WriteLine("it's a Squre");
        }
        //public void Perimeter()
        //{
        //    Console.WriteLine("Perimeter is ");
        //}
    }
}
