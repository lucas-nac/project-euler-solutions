using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Commons
{
    public static class Factors
    {
        public static IEnumerable<long> GetPrimeFactors(long n) {
            for (long i = 2; i < n/2; i++) {
                if (n % i == 0) {
                    return GetPrimeFactors(n/i).Append(i);
                }
            }
            return new List<long> { n };
        }

        public static IEnumerable<long> GetProperDivisors(long n) {
            for (long i = 1; i <= n/2; i++) {
                if (n % i == 0) {
                    yield return i;
                }
            }
        }
    }
}