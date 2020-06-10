using Calculator.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Operator = 0;
            while (Operator != 5)
            {
                try
                {
                    Console.WriteLine("Enter First Operand");
                    float Operand1 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter Second Operand");
                    float Operand2 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("1 For Addition");
                    Console.WriteLine("2 For Subtraction");
                    Console.WriteLine("3 For Multiplication");
                    Console.WriteLine("4 For Division");
                    Console.WriteLine("5 For Exit");
                    Console.WriteLine("Enter your choice");
                    Operator = Convert.ToInt32(Console.ReadLine());
                    float Result;
                    Calculation calculation = new Calculation();
                    if (Operator == 1)
                    {
                        Result = calculation.Sum(Operand1, Operand2);
                        Console.WriteLine("{0}+{1}={2}", Operand1, Operand2, Result);
                    }
                    else if (Operator == 2)
                    {
                        Result = calculation.Difference(Operand1, Operand2);
                        Console.WriteLine("{0}-{1}={2}", Operand1, Operand2, Result);
                    }
                    else if (Operator == 3)
                    {
                        Result = calculation.Product(Operand1, Operand2);
                        Console.WriteLine("{0}*{1}={2}", Operand1, Operand2, Result);
                    }
                    else if (Operator == 4)
                    {
                        Result = calculation.Quotient(Operand1, Operand2);
                        Console.WriteLine("{0}/{1}={2}", Operand1, Operand2, Result);
                    }
                    else if (Operator == 5)
                    {
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operator");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Operation");
                    Console.WriteLine("Occured error : {0}", ex);
                }
            }
            Console.ReadLine();
        }
    }
}

