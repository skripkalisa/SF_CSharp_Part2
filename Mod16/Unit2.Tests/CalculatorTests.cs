using System;
using Xunit;

namespace Unit2.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ProductShouldReturnNotNullValue()
        {
            var calculator = new Calculator();
            Assert.Equal(8, calculator.Product(2, 4));
        }

        [Fact]
        public void Subtraction_MustReturnCorrectValue() {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Subtraction(300, 10) == 290);
        }
  
        [Fact]
        public void Division_MustReturnCorrectValue() {
            var calculator = new Calculator();
            Assert.True(calculator.Division(200, 10) == 20);
        }
        [Fact]
        public void Division_MustThrowException() {
            var calculator = new Calculator();
            Assert.Throws < DivideByZeroException > (() => calculator.Division(30, 0));
        }
  
    }
}