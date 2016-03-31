using System.Collections.Generic;

namespace FibonacciSeries
{
    public class FibonacciSeries
    {
        public List<int> GetFibonacciNumbers(int length)
        {
            var fibonaccinumbers = new List<int>();
            for (var i = 0; i < length; i++)
            {
                if (i < 2)
                {
                    fibonaccinumbers.Add(i);
                    continue;
                }

                var currentFibonaccinumber = fibonaccinumbers[i - 1] + fibonaccinumbers[i - 2];
                fibonaccinumbers.Add(currentFibonaccinumber);
            }
            return fibonaccinumbers;
        }
    }
}

