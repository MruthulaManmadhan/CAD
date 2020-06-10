using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int Count = Convert.ToInt32(Console.ReadLine());
                for (int i = Count; i > 0; i--)
                {
                    for (int j = i; j < Count; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Occured error : {0}", ex);
            }
        }

    }
}
