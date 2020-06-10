using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linearsearch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] Numbers = new int[50];
                Console.WriteLine("Enter number of elements");
                int Count = Convert.ToInt32(Console.ReadLine());
                if (Count > 50)
                {
                    Console.WriteLine("Large array");
                }
                else
                {
                    Console.WriteLine("Enter each element");
                    Numbers= Get(Count);

                    Console.WriteLine("Enter number to be searched");
                    int Number = Convert.ToInt32(Console.ReadLine());

                    int Result = -1;

                    Result = Find(Numbers, Number);

                    if (Result == -1)
                    {
                        Console.WriteLine("Element {0} Not Found", Number);
                    }
                    else
                    {
                        Console.WriteLine("Element {0} found at index {1}", Number, Result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Operation");
                Console.WriteLine("Occured error : {0}", ex);
            }
            Console.ReadLine();
        }


        static int[] Get(int count)
        {
            int[] Numbers = new int[50];
            for (int i = 0; i < count; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return Numbers;
        }


        static int Find(int[] numbers,int number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
