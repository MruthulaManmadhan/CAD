using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> NumberArray = new List<int>();
            Console.WriteLine("Enter number of elements");
            int Count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements");
            for (int i = 0; i < Count; i++)
            {
                NumberArray.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Numbers before sorting : ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0}  ",NumberArray[i]);
            }
            Console.WriteLine("");
            NumberArray = Bubble(NumberArray);
            Console.WriteLine("Numbers after sorting : ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0}  ", NumberArray[i]);
            }
            Console.ReadLine();
        }
        public static List<int> Bubble(List<int> numberArray)
        {
            int Space;
            for (int i = 0; i <numberArray.Count; i++)
            {
                for (int j = 0; j <numberArray.Count-1; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        Space = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = Space;
                    }
                }
            }
            return numberArray;
        }
    }
}
