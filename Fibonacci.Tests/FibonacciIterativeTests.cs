namespace Fibonacci.Tests;

using System;
using System.Collections.Generic;
using System.Numerics;

using NUnit.Framework;

[TestFixture]
public class FibonacciIterativeTests
{
    private readonly FibonacciIterative _fibonacci;

    public FibonacciIterativeTests()
    {
        _fibonacci = new FibonacciIterative();
    }

    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(46, 1836311903)]
    public void Get_WhenNIs_ReturnsExpectedInt(int n, int expectedResultAsInt)
    {
        var expectedResult = new BigInteger(expectedResultAsInt);

        Assert.That(_fibonacci.Get(n), Is.EqualTo(expectedResult));
    }

    [Test]
    public void Get_NIsLessThanZero_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _fibonacci.Get(-1));

        Assert.That(ex?.Message, Is.EqualTo("n must be greater than or equal to 0."));
    }

    [Test]
    public void GetSequence_LengthIsNegative_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _fibonacci.GetSequence(-1));

        Assert.That(ex?.Message, Is.EqualTo("length must be greater than or equal to 0."));
    }

    [Test]
    public void GetSequence_LengthIsZero_ReturnsEmptyList()
    {
        var result = _fibonacci.GetSequence(0);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetSequence_LengthIsTwenty_ReturnsFirstTwentyFibonacciNumbers()
    {
        var expected = new List<BigInteger>
        {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34,
            55, 89, 144, 233, 377, 610, 987,
            1597, 2584, 4181
        };

        var result = _fibonacci.GetSequence(20);

        Assert.That(result, Is.EqualTo(expected));
    }
}
