using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution12 : ISolution
    {
        public string GetSolution()
        {
            var i = 1;
            long number = 0;
            long divisors = 0;

            while(divisors < 500) {
                number = GetTriangleNumber(i);
                var primeFactors = Factors.GetPrimeFactors(number);
                divisors = GetDivisorCount(primeFactors);
                i++;
            }               

            return number.ToString();
        }

        private long GetTriangleNumber(int n) {
            return Enumerable.Range(1, n).Sum();
        }

        private int GetDivisorCount(IEnumerable<long> primeFactors) {
            return primeFactors.GroupBy(f => f).Aggregate(1, (acc, g) => acc *= (int)g.Count() + 1);
        }
    }
}