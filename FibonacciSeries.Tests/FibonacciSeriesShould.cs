using System.Collections.Generic;
using NUnit.Framework;

namespace FibonacciSeries.Tests
{
    
    [TestFixture]
    public class FibonacciSeriesShould
    {
        [Test]
        public void return_a_list_containing_zero()
        {
            var fibonacciSeries = new FibonacciSeries();
            var LENGTH = 1;

            var fibonacciList = fibonacciSeries.GetFibonacciNumbers(LENGTH);

            Assert.That(fibonacciList, Is.EqualTo(new List<int> { 0 }));
        }

        [Test]
        public void return_one_as_the_second_number_in_output()
        {
            var fibonacciSeries = new FibonacciSeries();
            var LENGTH = 2;

            var fibonacciNumbers = fibonacciSeries.GetFibonacciNumbers(LENGTH);

            Assert.That(fibonacciNumbers, Is.EqualTo(new List<int> { 0, 1 }));
        }
    }
}
