using System;
namespace CalculatorWithTests
{
    public class Calculator
    {
        public int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public double SubtractTwoNumbers(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public long MultiplyTwoNumbers(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public decimal DivideTwoNumbers(decimal denominator, decimal numerator)
        {
            return denominator / numerator;
        }

        public int FindTheFactorial(int number)
        {
                if (number <= 1)
                {
                    return 1;
                }
                else
                {
                    return number * FindTheFactorial(number - 1);
                }
        }
    }
}
