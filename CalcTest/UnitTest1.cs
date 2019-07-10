using System;
using CalculatorWithTests;
using Xunit;

namespace CalcTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2,3,5)]
        public void AddTwoNumbers(int num1, int num2, int expectedSum)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.AddTwoNumbers(num1, num2);
            Assert.Equal(expectedSum, actual);
        }
    }
}
