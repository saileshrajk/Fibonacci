using System.Collections.Generic;

namespace FibonacciSeries
{
    public class FibonacciSeries
    {
        public List<int> GetFibonacciNumbers(int length)
        {
            var fibonaccinumbers = new List<int>();
            
            for (var index = 0; index < length; index++)
            {
                var currentFibonacciNumber = index < 2 
                    ? index 
                    : fibonaccinumbers[index - 1] + fibonaccinumbers[index - 2];
                fibonaccinumbers.Add(currentFibonacciNumber);
            }

            return fibonaccinumbers;
        }
    }
}

