using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Looper = 1;
                while (Looper == 1)
                {
                    Console.WriteLine("Enter a number");
                    int Number = Convert.ToInt32(Console.ReadLine());
                    int ReverseNumber = Reverse(Number);
                    Palindrome(Number, ReverseNumber);
                    Console.WriteLine("To continue enter 1");
                    Looper = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Occured error : {0}", ex);
            }
            Console.ReadLine();
        }
        static int Reverse(int number)
        {
            int ReverseNumber = 0;
            while (number != 0)
            {
                ReverseNumber = ((ReverseNumber*10)+number % 10);
                number = number / 10;
            }
            return ReverseNumber;
        }
        static void Palindrome(int number,int reverseNumber)
        {
            if(number==reverseNumber)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }
    }
}
