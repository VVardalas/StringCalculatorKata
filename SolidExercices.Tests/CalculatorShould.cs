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
            Check.That(result).IsEqualTo(3.3m);
        }

        [Test]
        public void CalculateASoustraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("2,3-1");
            Check.That(result).IsEqualTo(1.3m);
        }

        [Test]
        public void CalculateAMultiplication()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5*10");
            Check.That(result).IsEqualTo(50m);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("14/2");
            Check.That(result).IsEqualTo(7m);
        }

        [Test]
        public void CalculateManySums()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3+3+3,7");
            Check.That(result).IsEqualTo(10m);
        }

        [Test]
        public void CalculateManySoustractions()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("2,3-1-5-6");
            Check.That(result).IsEqualTo(-9.7m);
        }

        [Test]
        public void CalculateManyMultiplications()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5*10*30*0,5");
            Check.That(result).IsEqualTo(750m);
        }

        [Test]
        public void CalculateManyDivisions()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("50/2/5");
            Check.That(result).IsEqualTo(5m);
        }

        [Test]
        public void Exceptions()
        {
            var calculator = new Calculator();
            Check.ThatCode(() => calculator.Calculate("50")).Throws<NotImplementedException>();
            
        }
    }
}
