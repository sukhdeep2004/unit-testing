using NUnit.Framework;
using Calculator.service;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private Calculate _calc;

        [SetUp]
        public void SetUp()
        {
            _calc = new Calculate();
        }

        [Test]
        public void Addition_test()
        {
            var result = _calc.Add(1, 2);

            Assert.That(result, Is.EqualTo(3), $"Expected {result} to be 3");
        }
        [Test]
        public void Subtraction_test()
        {
            var result = _calc.Subtract(5, 2);
            Assert.That(result, Is.EqualTo(3), $"Expected {result} to be 3");
        }
        [Test]
        public void Multiplication_test()
        {
            var result = _calc.Multiply(5, 2);
            Assert.That(result, Is.EqualTo(10), $"Expected {result} to be 10");
        }
        [Test]
        public void Division_test()
        {
            var result = _calc.Divide(10, 2);
            Assert.That(result, Is.EqualTo(5), $"Expected {result} to be 5");
        }
        [Test]
        public void Division_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(5, 0));
        }
        [TestCase(10, 3, 1)]
        [TestCase(9, 3, 0)]
        public void Modulus_ShouldReturnCorrectRemainder(int a, int b, int expected)
        {
            var result = _calc.Modulus(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Factorial_ShouldReturnCorrectValue()
        {
            Assert.That(_calc.Factorial(5), Is.EqualTo(120));
        }

        [Test]
        public void Factorial_NegativeNumber_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => _calc.Factorial(-1));
        }

        [TestCase(16, 4)]
        [TestCase(9, 3)]
        public void SquareRoot_ShouldReturnExpected(double n, double expected)
        {
            var result = _calc.SquareRoot(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SquareRoot_Negative_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => _calc.SquareRoot(-9));
        }
        [Test]
        public void Division_ShouldReturnDoublePrecision()
        {
            var result = _calc.Divide(1, 3);
            Assert.That(result, Is.EqualTo(0.3333).Within(0.0001));
        }
    }
}
