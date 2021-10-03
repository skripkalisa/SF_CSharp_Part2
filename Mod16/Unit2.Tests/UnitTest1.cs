using System;
using NUnit.Framework;


namespace Unit2.Tests
{
    [TestFixture]
    public class Class1
    {
                [Test]
        public void SumAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Sum(10, 220), Is.EqualTo(230));
        }
        
        [Test]
        public void Subtraction_MustReturnCorrectValue() {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }
        
        [Test]
        public void Division_MustReturnCorrectValue() {
            var calculator = new Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }

        [TestFixture]
        public class CalculatorTests {
            [Test]
            public void Division_MustThrowException() {
                var calculator = new Calculator();
                Assert.Throws < DivideByZeroException > (() => calculator.Division(30, 0));
            }
        }
    }
}