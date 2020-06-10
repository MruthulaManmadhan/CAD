using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int Result = Power(Num1, Num2);
            Console.WriteLine("{0}^{1}={2}",Num1,Num2,Result);
            Console.ReadLine();
        }
        public static int Power(int num1,int num2)
        {
            if(num2>1)
            {

                return (Power(num1, num2-1)*num1);
            }
            else
            {
                return num1;
            }
        }
    }
}
