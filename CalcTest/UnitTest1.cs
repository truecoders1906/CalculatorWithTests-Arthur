using System;
using CalculatorWithTests;
using Xunit;

namespace CalcTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2,3,5)]
        [InlineData(1,1,2)]
        [InlineData(10,14,24)]
        [InlineData(-12,11,-1)]
        [InlineData(9000,1,9001)]
        public void AddTwoNumbers(int num1, int num2, int expectedSum)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.AddTwoNumbers(num1, num2);
            Assert.Equal(expectedSum, actual);
        }

        [Theory]
        [InlineData(15,7,8)]
        [InlineData(1,6,-5)]
        [InlineData(11.7,9.2,2.5)]
        [InlineData(1000,500,500)]
        [InlineData(26,39,-13)]
        public void SubtractTwoNumbers(double minuend, double subtrahend, double expectedSum)
        {
            Calculator challenger = new Calculator();
            double actual = challenger.SubtractTwoNumbers(minuend, subtrahend);
            Assert.Equal(expectedSum, actual);
        }

        [Theory]
        [InlineData(2,4,8)]
        [InlineData(13,6,78)]
        [InlineData(-9,12,-108)]
        [InlineData(-1,-1,1)]
        [InlineData(420,0,0)]
        public void MultiplyTwoNumbers(long factor1, long factor2, long expectedSum)
        {
            Calculator challenger = new Calculator();
            long actual = challenger.MultiplyTwoNumbers(factor1, factor2);
            Assert.Equal(expectedSum, actual);
        }

        [Theory]
        [InlineData(1,0.5,2)]
        [InlineData(13,6,2.17)]
        [InlineData(20,2,10)]
        [InlineData(-5,1,-5)]
        [InlineData(45,10,4.5)]
        public void DivideTwoNumbers(decimal denominator, decimal numerator, decimal expectedSum)
        {
            Calculator challenger = new Calculator();
            decimal actual = challenger.DivideTwoNumbers(denominator, numerator);
            Assert.Equal(expectedSum, actual);
        }

        [Theory]
        [InlineData(1,1)]
        [InlineData(2,2)]
        [InlineData(3,6)]
        [InlineData(4,24)]
        [InlineData(5,120)]
        public void FindTheFactorial(int number, int expectedSum)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.FindTheFactorial(number);
            Assert.Equal(expectedSum, actual);
        }
    }
}
