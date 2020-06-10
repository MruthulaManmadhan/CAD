using System;
using System.Collections.Generic;

namespace Animal
{
    class Program
    {
        abstract class Animal
        {
            public string Name { get; set; }
            public string Colour { get; set; }
            public string Sound { get; set; }
        }
        class Dog:Animal
        {
            public Dog(string name,string colour)
            {
                Name = name;
                Colour = colour;
                Sound = "bow bow";
            }
        }
        class Cat:Animal
        {
            public Cat(string name, string colour)
            {
                Name = name;
                Colour = colour;
                Sound = "meaw meaw";
            }
        }
        static void Main(string[] args)
        {
            List<Dog> DogList = new List<Dog>();
            List<Cat> CatList = new List<Cat>();
            Dog dog1 = new Dog("Jackey", "Black");
            DogList.Add(dog1);
            Dog dog2 = new Dog("Arjun", "White");
            DogList.Add(dog2);
            Dog dog3 = new Dog("Ruby", "Brown");
            DogList.Add(dog3);
            Dog dog4 = new Dog("Jimmy", "White");
            DogList.Add(dog4);
            Cat cat1 = new Cat("Chakki", "Black");
            CatList.Add(cat1);
            Cat cat2 = new Cat("Kingini", "Brown");
            CatList.Add(cat2);
            Cat cat3 = new Cat("Dudo", "Black");
            CatList.Add(cat3);
            Cat cat4 = new Cat("Luckey", "White");
            CatList.Add(cat4);
            Console.WriteLine("Brown coloured animals are : ");
            for (int i = 0; i < DogList.Count; i++)
            {
                if(DogList[i].Colour=="Brown")
                {
                    Console.WriteLine("Name : {0} Colour : {1} Sound : {2}",DogList[i].Name,DogList[i].Colour,DogList[i].Sound);
                }
                if (CatList[i].Colour == "Brown")
                {
                    Console.WriteLine("Name : {0} Colour : {1} Sound : {2}", CatList[i].Name, CatList[i].Colour, CatList[i].Sound);
                }
            }
            Console.WriteLine("White coloured Cats are : ");
            for (int i = 0; i < CatList.Count; i++)
            {
                if (CatList[i].Colour == "White")
                {
                    Console.WriteLine("Name : {0} Colour : {1} Sound : {2}", CatList[i].Name, CatList[i].Colour, CatList[i].Sound);
                }
            }
            Console.ReadLine();
        }
    }
}
