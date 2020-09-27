using System;
using System.Collections.Generic;
using System.Linq;

namespace project_euler_solutions.solutions
{
    public class Solution2 : ISolution
    {
        public string GetSolution()
        {
            return GetFibonacciValuesUnder(4000000).Where(v => v % 2 == 0).Sum().ToString();
        }

        private IEnumerable<long> GetFibonacciValuesUnder(long limit) {
            long currentValue = 0, penultimateValue = 0, lastValue = 1;

            while ((currentValue = penultimateValue + lastValue) <= limit) {
                penultimateValue = lastValue;
                lastValue = currentValue;
                yield return currentValue;
            }
        }
    }
}