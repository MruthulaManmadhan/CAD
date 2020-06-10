using System;

namespace OOPS1
{
    public abstract class Vehicle
    {
        public string colour="Red";
        public virtual void display()
        {

        }
    }
    public class Bike:Vehicle
    {
        public int NumberOfWheels = 2;
        public override void display()
        {
            Console.WriteLine("This is a Bike");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Bike();
            Bike b = new Bike();
            Console.WriteLine("colour={0} number of wheels={1}",b.colour,b.NumberOfWheels);
            b.display();
            Console.ReadLine();
        }
    }
}
