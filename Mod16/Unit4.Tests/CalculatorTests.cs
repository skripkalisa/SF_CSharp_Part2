using Xunit;

namespace Unit4.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void SumMustReturnCorrectValue() 
        {
            var calculator = new Calculator();
            int result = calculator.Sum(50, 10, 34);
            Assert.Equal(94, result);
        }

        [Fact]
        public void ProductMustReturnCorrectValue() 
        {
            var calculator = new Calculator();
            int result = calculator.Product(3, 2, 20);
            Assert.Equal(120, result);
        } 
    }
}