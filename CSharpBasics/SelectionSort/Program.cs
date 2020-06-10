using System;
namespace SelectionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] Numbers = new int[20];
                Console.WriteLine("Enter number of elements");
                int Count = Convert.ToInt32(Console.ReadLine());
                if (Count > Numbers.Length)
                {
                    Console.WriteLine("Array limit exceeded");
                }
                else
                {
                    Console.WriteLine("Enter elements");
                    for (int i = 0; i < Count; i++)
                    {
                        Numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Numbers = Sort(Numbers, Count);
                    Console.WriteLine("Array after sorting");
                    for (int i = 0; i < Count; i++)
                    {
                        Console.WriteLine("{0}  ", Numbers[i]);
                    }
                    //Console.WriteLine(String.Join(",", Numbers.Select(n => n.ToString()).ToArray()));
                    //Console.WriteLine(Numbers.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();
        }
        public static int[] Sort(int[] numbers,int count)
        {
            int min,t;
            for (int i = 0; i < count-1; i++)
            {
                min = i;
                for (int j = i; j < count; j++)
                {
                    if(numbers[min]>numbers[j])
                    {
                        min = j;
                    }
                }
                t = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = t;
            }
            return numbers;
        }
    }
}
