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

        [Test]
        public void return_a_list_containing_zero()
        {
            var LENGTH = 1;

            var fibonacciList = _fibonacciSeries.GetFibonacciNumbers(LENGTH);

            Assert.That(fibonacciList, Is.EqualTo(new List<int> {0}));
        }

        [Test]
        public void return_one_as_the_second_number_in_output()
        {
            var LENGTH = 2;

            var fibonacciNumbers = _fibonacciSeries.GetFibonacciNumbers(LENGTH);

            Assert.That(fibonacciNumbers, Is.EqualTo(new List<int> {0, 1}));
        }

        [Test]
        public void return_first_three_elements_of_fibonacci_series_given_length_of_3()
        {
            var LENGTH = 3;

            var fibonacciNumbers = _fibonacciSeries.GetFibonacciNumbers(LENGTH);

            Assert.That(fibonacciNumbers, Is.EqualTo(new List<int> {0, 1, 1}));
        }

        [TestCase(1, new[] {0})]
        [TestCase(2, new[] {0, 1})]
        [TestCase(3, new[] {0, 1, 1})]
        public void ReturnFibonacciNumbers_GivenLength(int length, int[] expectedFibonacciNumbers)
        {
            var fibonacciNumbers = _fibonacciSeries.GetFibonacciNumbers(length);

            Assert.That(fibonacciNumbers, Is.EqualTo(expectedFibonacciNumbers));
        }
    }
}
