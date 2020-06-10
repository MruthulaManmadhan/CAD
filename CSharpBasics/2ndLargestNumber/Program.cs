using System;

namespace _2ndLargestNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];
            Console.WriteLine("Enter the number of elements in an array");
            int Number = Convert.ToInt32(Console.ReadLine());
            if(Number<=10)
            {
                Console.WriteLine("Enter the elements");
                for (int i = 0; i < Number; i++)
                {
                    Numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                int SecondLarge = FindSecondLarge(Numbers,Number);
                Console.WriteLine("second largest number is {0}",SecondLarge);
            }
            else
            {
                Console.WriteLine("Sorry Large array!!");
            }
            Console.ReadLine();
        }
        public static int FindSecondLarge(int[] numbers,int number)
        {
            int Large=numbers[0], SecondLarge= Int32.MinValue,t;
            for (int i = 0; i < number; i++)
            {
                if(numbers[i]>SecondLarge)
                {
                    SecondLarge = numbers[i];
                    if(Large<SecondLarge)
                    {
                        t = SecondLarge;
                        SecondLarge = Large;
                        Large = t;
                    }
                }
            }
            return SecondLarge;
        }
    }
}
