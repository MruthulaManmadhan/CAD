using System;

namespace SquareRoot
{
    public class Program
    {
        static void Main(string[] args)
        {
            double first = 1, number;
            Console.WriteLine("Ener anumber to find square root");
            number = Convert.ToInt32(Console.ReadLine());
            double sqrt = GetSquareRoot(first, number, number);
            Console.WriteLine("Square root of {0} is {1}", number, sqrt);
            Console.ReadLine();
        }
        public static double GetSquareRoot(double first, double second, double result)
        {
            double mid = (first + second) / 2;
            if (mid * mid > result * 1.0000000001)
            {
                return GetSquareRoot(first, mid, result);
            }
            else if (mid * mid < result * 0.9999999999)
            {
                return GetSquareRoot(mid, second, result);
            }
            else
            {
                return (mid);
            }
        }
    }
}
