using System;

namespace ReverseArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10];
            Console.WriteLine("Enter count of elements");
            int Count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements");
            for (int i = 0; i <Count; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0}  ",Array[i]);
            }
            Array = Reverse(Array,Count);
            Console.WriteLine("The array after reversing:");
            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0}  ", Array[i]);
            }
        }
        public static int[] Reverse(int[] array,int count)
        {
            int temp;
            for (int i = 0; i < count/2; i++)
            {
                temp = array[i];
                array[i] = array[(count-1) - i];
                array[(count-1) - i] = temp;
            }
            return array;
        }
    }
}
