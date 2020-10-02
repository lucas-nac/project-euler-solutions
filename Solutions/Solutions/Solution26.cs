using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution26 : ISolution
    {
        public string GetSolution()
        {
            return Enumerable.Range(2, 998).OrderByDescending(n => GetRecurringDecimalsCount(n)).First().ToString();
        }

        private int GetRecurringDecimalsCount(int n) {
            var digits = new List<Tuple<int, int>>();
            var remainder = 1;

            while (remainder != 0 && digits.Count <= n) {
                remainder *= 10;

                var digit = remainder / n;
                var remainderDigitPair = new Tuple<int, int>(remainder, digit);

                if (digits.Contains(remainderDigitPair)) return digits.Skip(digits.FindIndex(p => p == remainderDigitPair)).Count();
                
                digits.Add(remainderDigitPair);
                remainder %= n;
            }

            return 0;
        }
    }    
}