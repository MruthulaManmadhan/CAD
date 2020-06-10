using System;
using System.Collections.Generic;

namespace Vehicle
{
    class Program
    {
        abstract class Vehicle
        {
            public string Colour { get; set; }
            public int Year { get; set; }
            public string Manufacturer { get; set; }
        }
        class Car : Vehicle
        {
            public Car(string colour,int year, string manufacturer)
            {
                Colour = colour;
                Year = year;
                Manufacturer = manufacturer;
            }
        }
        class Bike : Vehicle
        {
            public Bike(string colour,int year, string manufacturer)
            {
                Colour = colour;
                Year = year;
                Manufacturer = manufacturer;
            }
        }
        static void Main(string[] args)
        {
            List<Car> CarList = new List<Car>();
            List<Bike> BikeList = new List<Bike>();
            CarList.Add(new Car("Red",2015,"Toyota"));
            CarList.Add(new Car("Blue",2018,"Suzuki"));
            CarList.Add(new Car("White",2017,"Toyota"));
            CarList.Add(new Car("Red",2016,"Maruthi"));
            BikeList.Add(new Bike("Black",2015,"Hero"));
            BikeList.Add(new Bike("Red",2018,"Honda"));
            BikeList.Add(new Bike("Black",2017,"Royal Enfield"));
            BikeList.Add(new Bike("Blue",2018,"Splender"));
            Console.WriteLine("Red coloured cars are : ");
            for (int i = 0; i < CarList.Count; i++)
            {
                if (CarList[i].Colour == "Red")
                {
                    Console.WriteLine("Colour : {0} Year : {1} Manufacturer : {2}", CarList[i].Colour, CarList[i].Year, CarList[i].Manufacturer);
                }
            }
            Console.WriteLine("Manufacturer details of black bikes : ");
            for (int i = 0; i < BikeList.Count; i++)
            {
                if (BikeList[i].Colour == "Black")
                {
                    Console.WriteLine("Manufacturer : {0} ", BikeList[i].Manufacturer);
                }
            }
            Console.ReadLine();
        }
    }
}
