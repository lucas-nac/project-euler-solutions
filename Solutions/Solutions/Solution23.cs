using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution23 : ISolution
    {
        private const int limit = 28123;
        public string GetSolution()
        {
            var abundantNumbers = Enumerable.Range(1, limit).Where(n => Factors.GetProperDivisors(n).Sum() > n).ToArray();
            var abundantSums = new Dictionary<int, bool>();

            for (int i = 0; i < abundantNumbers.Length; i++) {
                for (int j = i; j < abundantNumbers.Length; j++)
                {
                    var sum = abundantNumbers[i] + abundantNumbers[j];
                    if (sum > limit) break;
                    abundantSums[sum] = true;
                }
            }
        
            return Enumerable.Range(1, limit).Except(abundantSums.Keys).Sum().ToString();
        }
    }    
}