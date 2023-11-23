namespace Fibonacci.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class FibonacciRecursiveTests
    {
        private readonly FibonacciRecursive _fibonacci;

        public FibonacciRecursiveTests()
        {
            _fibonacci = new FibonacciRecursive();
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(46, 1836311903)]
        public void GetFibonacci_WhenNIs_ReturnsExpectedInt(int n, int expectedResult)
        {
            Assert.That(_fibonacci.GetFibonacci(n), Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetFibonacci_NIsLessThanZero_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _fibonacci.GetFibonacci(-1));

            Assert.That(ex?.Message, Is.EqualTo("n must be greater than or equal to 0."));
        }

        [Test]
        public void GetFibonacci_NIsGreaterThanFortySix_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _fibonacci.GetFibonacci(47));

            Assert.That(ex?.Message, Is.EqualTo("n must be less than or equal to 46. (int32 does not support)"));
        }

        [Test]
        public void GetFibonacciSequence_LengthIsNegative_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _fibonacci.GetFibonacciSequence(-1));

            Assert.That(ex?.Message, Is.EqualTo("length must be greater than or equal to 0."));
        }

        [Test]
        public void GetFibonacciSequence_LengthIsGreaterThanFortySix_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _fibonacci.GetFibonacciSequence(47));

            Assert.That(ex?.Message, Is.EqualTo("length must be less than or equal to 46. (int32 does not support)"));
        }

        [Test]
        public void GetFibonacciSequence_LengthIsZero_ReturnsEmptyList()
        {
            var result = _fibonacci.GetFibonacciSequence(0);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetFibonacciSequence_LengthIsTwenty_ReturnsFirstTwentyFibonacciNumbers()
        {
            var expected = new List<int>
            {
                0, 1, 1, 2, 3, 5, 8, 13, 21, 34,
                55, 89, 144, 233, 377, 610, 987,
                1597, 2584, 4181
            };

            var result = _fibonacci.GetFibonacciSequence(20);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}