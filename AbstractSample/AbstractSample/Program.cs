using System;

namespace AbstractSample
{
    class Program
    {
        abstract class Vehicle
        {
            public int NumberOfTyres { get; set; }
            public virtual int GetCost()
            {
                return 0;
            }
        }
        class Car:Vehicle
        {
            public override int GetCost()
            {
                return 400000;
            }
            public string Details()
            {
                return "Racing car";
            }
        }
        class Bike:Vehicle
        {

            public override int GetCost()
            {
                return 70000;
            }
            public string Model()
            {
                return "2017 model";
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            car.NumberOfTyres = 4;
            Console.WriteLine("Number of tyres : {0} Car cost : {1} Details : {2}",car.NumberOfTyres,car.GetCost(),car.Details());
            Bike bike = new Bike();
            bike.NumberOfTyres = 2;
            Console.WriteLine("Number of tyres : {0} Car cost :{1} Model : {2}", bike.NumberOfTyres, bike.GetCost(),bike.Model());
            Console.ReadLine();
        }
    }
}
