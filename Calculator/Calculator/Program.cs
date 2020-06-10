using Calculator.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i >0; i++)
            {
                if ((i % 2 == 1) && (i % 3 == 1) && (i % 4 == 1) && (i % 5 == 1) && (i % 6 == 1) && (i % 7 == 0))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}

