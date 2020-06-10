
using System;

namespace ExcelSheet
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result=0, number;
            Console.WriteLine("Enter the excel columm");
            string excel = Console.ReadLine();
            for (int i = 0; i < excel.Length; i++)
            {
                //Console.WriteLine((int)excel[i]);
                number = char.ToUpper(excel[i]) -'A'+1;
                result = (result * 26) + number;
            }
            Console.WriteLine("column number corresponding to {0} is {1}",excel,result);
            Console.ReadLine();
        }
    }
}
