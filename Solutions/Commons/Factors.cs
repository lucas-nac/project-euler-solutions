using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Commons
{
    public static class Factors
    {
        public static IEnumerable<long> GetFactors(long n) {
            for (long i = 2; i < n/2; i++) {
                if (n % i == 0) {
                    return GetFactors(n/i).Append(i);
                }
            }
            return new List<long> { n };
        }
    }
}