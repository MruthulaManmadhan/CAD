using System;
using System.Linq;

namespace ToStringForAnArray
{
    public class IntegerList
    {
        public int[] Array = new int[] { 1, 2, 3, 4, 5 };

        public override string ToString()
        {
            string concatenated = string.Join(",", Array);
            return concatenated;
            //return (String.Join(",", Array.Select(p => p.ToString()).ToArray()));

            //return ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList integerList = new IntegerList();
            //int[] Array = new int[] { 1, 2, 3, 4,5 };
            Console.Write("Array before ToString    :   ");
            for (int i = 0; i < integerList.Array.Length; i++)
            {
                Console.Write("{0}  ", integerList.Array[i]);
            }
            Console.WriteLine();
            Console.Write("Array after ToString");
            //Console.WriteLine(String.Join(",", Array.Select(p => p.ToString()).ToArray()));
            Console.WriteLine(integerList.ToString());
            Console.ReadLine();

        }
    }
}
