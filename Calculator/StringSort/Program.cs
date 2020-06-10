using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] StringArray = new string[20];
                Console.WriteLine("Enter number of strings");
                int Count = Convert.ToInt32(Console.ReadLine());
                if (Count <= 20)
                {
                    Console.WriteLine("Enter strings");
                    for (int i = 0; i < Count; i++)
                    {
                        StringArray[i] = Convert.ToString(Console.ReadLine());
                    }
                    Console.WriteLine("strings before sorting");
                    WriteStrings(StringArray);
                    string[] SortedArray = Sort(StringArray);
                    Console.WriteLine("strings after sorting");
                    WriteStrings(SortedArray);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Occured error : {0}", ex);
            }
            Console.ReadLine();
        }


        //method for sorting the string array
        static string[] Sort(string[] stringArray)
        {
            Array.Sort(stringArray, StringComparer.InvariantCulture);
            return stringArray;
        }


        //method for printing the array of strings
        static void WriteStrings(string[] ArrayOfStrings)
        {
            for (int i = 0; i < ArrayOfStrings.Length; i++)
            {
                Console.WriteLine(ArrayOfStrings[i]);
            }
        }
    }
}
