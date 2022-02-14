using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution41 : ISolution
    {
        private static IList<long> primeNumbers = PrimeNumbers.GetPrimeNumbersBelow(7654321).OrderByDescending(n => n).ToList();
        
        public string GetSolution()
        {
            foreach (var n in primeNumbers)
            {
                if (!isPandigital(n)) continue;
                return n.ToString();
            }

            return string.Empty;
        }

        private static bool isPandigital(long n)
        {
            var nString = n.ToString();

            if (nString.Contains('0')) return false;

            for (int i = 1; i <= nString.Length; i++)
            {
                var c = '0' + i;
                if (nString.Count(d => d == c) != 1) return false;
            }

            return true;
        }
    }    
}