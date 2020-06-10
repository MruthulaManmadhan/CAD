using System;

namespace Overloading
{
    class Program
    {
        class Sample
        {
            public void Add(int a, int b)
            {
                Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                Console.ReadLine();
            }
            public void Add(int a, int b,int c)
            {
                Console.WriteLine("{0}+{1}+{2}={3}",a, b, c, a + b + c);
                Console.ReadLine();
            }
            public void Add(int a, int b,int c,int d)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}={4}",a, b, c, d, a + b + c + d);
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.Add(1,2);
            s.Add(1,2,3);
            s.Add(1,2,3,4);
        }
    }
}
