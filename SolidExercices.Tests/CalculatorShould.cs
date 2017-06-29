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
    }
}
