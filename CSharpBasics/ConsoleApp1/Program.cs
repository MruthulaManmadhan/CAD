using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = 5.4;
            Console.WriteLine("Type of d is {0}", d.GetType().ToString());
            Console.WriteLine("enter your name");
            string Name = Console.ReadLine();
            string Reverse = "";
            for (int i = Name.Length-1; i >= 0; i--)
            {
                Reverse += Name[i];
            }
            Console.WriteLine("Reverse: {0}",Reverse);
            Console.ReadLine();
        }

    }
}

       
