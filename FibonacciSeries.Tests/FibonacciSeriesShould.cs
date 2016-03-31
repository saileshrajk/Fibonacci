using System.Collections.Generic;
using NUnit.Framework;

namespace FibonacciSeries.Tests
{

    [TestFixture]
    public class FibonacciSeriesShould
    {
        private FibonacciSeries _fibonacciSeries;

        [SetUp]
        public void Setup()
        {
            _fibonacciSeries = new FibonacciSeries();
        }

        [TestCase(1, new[] {0})]
        [TestCase(2, new[] {0, 1})]
        [TestCase(3, new[] {0, 1, 1})]
        [TestCase(5, new[] {0, 1, 1, 2, 3})]
        public void ReturnFibonacciNumbers_GivenLength(int length, int[] expectedFibonacciNumbers)
        {
            var fibonacciNumbers = _fibonacciSeries.GetFibonacciNumbers(length);

            Assert.That(fibonacciNumbers, Is.EqualTo(expectedFibonacciNumbers));
        }
    }
}
