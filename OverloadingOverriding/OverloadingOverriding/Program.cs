using System;

namespace OverloadingOverriding
{
    class Program
    {
        class Base
        {
            public virtual void Override()
            {
                Console.WriteLine("Base Class");
            }            
        }
        class Derived:Base
        {
            public override void Override()
            {
                Console.WriteLine("Derived Class");
            }
            public void Display(int a)
            {
                Console.WriteLine("Display with 1 int parameter");
            }
            public void Display(int a,int b)
            {
                Console.WriteLine("Display with 2 int parameter");
            }
            public void Display(float a)
            {
                Console.WriteLine("Display with parameter float");
            }
        }
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.Override();
            d.Display(1);
            d.Display(1, 2);
            d.Display(3.5f);
            Console.ReadLine();
        }
    }
}
