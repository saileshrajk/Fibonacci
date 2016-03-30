using System.Collections.Generic;

namespace FibonacciSeries
{
    public class FibonacciSeries
    {
        public List<int> GetFibonacciNumbers(int length)
        {
            if (length == 1)
            {
                return new List<int> { 0 };
            }

            return new List<int> { 0, 1 };
        }
    }
}

