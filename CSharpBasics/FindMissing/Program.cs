using System;

namespace FindMissing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] BigArray = new int[20];
            int[] SmallArray = new int[19];
            Console.WriteLine("Enter size of long array");
            int Number = Convert.ToInt32(Console.ReadLine());
            if(Number>BigArray.Length)
            {
                Console.WriteLine("Large array");
            }
            else
            {
                Console.WriteLine("Enter digits to long array");
                for (int i = 0; i < Number; i++)
                {
                    BigArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Enter digits to small array");
                for (int i = 0; i < Number-1; i++)
                {
                    SmallArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                int ExtraNumber = Missing(BigArray, SmallArray, Number);
                if(ExtraNumber==int.MinValue)
                {
                    Console.WriteLine("Not Found any missing Numer");
                }
                else
                {
                    Console.WriteLine("Extra Numbber in big array is : {0}",ExtraNumber);
                }
            }
            Console.ReadLine();
        }
        public static int Missing(int[] bigArray,int[] smallArray,int number)
        {
            for (int i = 0; i < number; i++)
            {
                if((Search(smallArray, number - 1, bigArray[i])==false))
                {
                    return bigArray[i];
                }
            }
            return int.MinValue;
        }
        public static bool Search(int[] smallArray,int count,int number)
        {
            for (int i = 0; i < count; i++)
            {
                if(number==smallArray[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
