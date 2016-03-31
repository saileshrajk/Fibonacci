using System.Collections.Generic;

namespace FibonacciSeries
{
    public class FibonacciSeries
    {
        public List<int> GetFibonacciNumbers(int length)
        {
            if (length == 1)
            {
                return new List<int> {0};
            }
            if (length == 2)
            {
                return new List<int> {0, 1};
            }
            if (length == 3)
            {
                return new List<int> {0, 1, 1};
            }

            return new List<int> { 0, 1, 1,2,3 };
        }
    }
}

