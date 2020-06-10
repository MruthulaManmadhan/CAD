using System;

namespace Laptop
{
    class Program
    {
        abstract class Laptop
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Processor { get; set; }
        }
        class LaptopDetails:Laptop
        {
            public void Getdate()
            {
                Console.WriteLine("Enter the name of laptop");
                Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the price of laptop");
                Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the processor of laptop");
                Processor = Convert.ToString(Console.ReadLine());
            }
            public void Display()
            {
                Console.WriteLine("Name : {0} Price : {1} Processor : {2}",Name,Price,Processor);
            }
        }
        static void Main(string[] args)
        {
            LaptopDetails laptop = new LaptopDetails();
            laptop.Getdate();
            Console.ReadLine();
            laptop.Display();
            Console.ReadLine();
        }
    }
}
