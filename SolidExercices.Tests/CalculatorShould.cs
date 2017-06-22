using System;
using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }
        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("3*9,2");
            Check.That(result).IsEqualTo(27.6);
        }
        [Test]
        public void CalculateASubsraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("6-10");
            Check.That(result).IsEqualTo(-4);

        }
        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("10/10");
            Check.That(result).IsEqualTo(1);
        }
        [Test]
        public void DivisionByZeroShouldReturnException()
        {

            var calculator = new Calculator();
            var result = calculator.Calculate("10/0");
            Assert.Throws(typeof(DivideByZeroException),CalculateADivision);
        }
    }
}
