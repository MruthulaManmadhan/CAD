using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNullCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            CheckEmpty(Numbers);
            Numbers.Add(22);
            CheckEmpty(Numbers);
            Console.ReadLine();
        }
        public static void CheckEmpty(List<int> numbers)
        {
            if (!numbers.Any())
            {
                Console.WriteLine("Empty List");
            }
            else
            {
                Console.WriteLine("Not an empty string");
            }
        }
    }
}
