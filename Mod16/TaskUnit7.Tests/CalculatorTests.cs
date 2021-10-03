using System;
using NUnit.Framework;

namespace TaskUnit7.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }
        
        [Test]
        public void SubtractAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Subtract(40, 20), Is.EqualTo(20));
        }   
        
        [Test]
        public void MultiplyAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Multiply(40, 20), Is.EqualTo(800));
        }    
        
        [Test]
        public void DivideAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Divide(40, 20), Is.EqualTo(2));
        }       
        [Test]
        public void Divide_MustThrowException()
        {
            var calculatorTest = new Calculator();
            Assert.Throws <DivideByZeroException> (() => calculatorTest.Divide(40, 0));
        }
    }
}