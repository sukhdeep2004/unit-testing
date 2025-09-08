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
    }
}
