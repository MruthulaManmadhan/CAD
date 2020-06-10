using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    class Calculation
    {
        public float Sum(float operand1, float operand2)
        {
            float Result = operand1 + operand2;
            return Result;
        }
        public float Difference(float operand1, float operand2)
        {
            float Result = operand1 - operand2;
            return Result;
        }
        public float Product(float operand1, float operand2)
        {
            float Result = operand1 * operand2;
            return Result;
        }
        public float Quotient(float operand1, float operand2)
        {
            float Result = operand1 / operand2;
            return Result;
        }

    }
}
