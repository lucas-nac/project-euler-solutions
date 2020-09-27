using System;
using System.Collections.Generic;
using System.Linq;

namespace project_euler_solutions.solutions
{
    public class Solution3 : ISolution
    {        
        public string GetSolution()
        {
            return GetFactors(600851475143).Max().ToString();
        }

        private IEnumerable<long> GetFactors(long n) {
            for (long i = 2; i < n/2; i++) {
                if (n % i == 0) {
                    return GetFactors(n/i).Append(i);
                }
            }
            return new List<long> { n };
        }
    }
}