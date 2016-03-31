using System.Collections.Generic;
using System.Linq;

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

            var fibonaccinumbers = new List<int>();
            for (int i = 0; i < length; i++)
            {
                //give me the last index
                //retrieve last element
                // curr = last + secondLast

                if (i == 0 || i== 1)
                {
                    fibonaccinumbers.Add(i);
                    continue;
                }

                var lastIndex = fibonaccinumbers.Count -1;

                var secondLastIndex = lastIndex - 1;

                var currentFibonaccinumber = fibonaccinumbers[lastIndex] + fibonaccinumbers[secondLastIndex];

                fibonaccinumbers.Add(currentFibonaccinumber);
            }

            return fibonaccinumbers;

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

