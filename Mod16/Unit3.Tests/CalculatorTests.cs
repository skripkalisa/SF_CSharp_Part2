using NUnit.Framework;

namespace Unit3.Tests
{
    [TestFixture]
    public class CalculatorTests
    {        
        [Test]
        public void SumAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Sum(10, 220), Is.EqualTo(230));
        }
        
    }
}