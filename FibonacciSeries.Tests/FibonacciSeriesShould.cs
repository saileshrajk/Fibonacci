using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var fibonacciList = fibonacciSeries.GetList();
            
            Assert.That(new List<int>{0}, Is.EqualTo(fibonacciList));
        }
    }
}
