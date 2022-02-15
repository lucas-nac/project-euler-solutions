using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;
using Solutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution43 : ISolution
    {
        private static IList<long> primeNumbers = PrimeNumbers.GetPrimeNumbersBelow(1000).ToList();
        private static IList<string> pandigitalNumbers = PandigitalNumbers.GetNPandigitalNumbers(10, true).ToList();

        public string GetSolution()
        {
            var sum = (long)0;

            foreach (var n in pandigitalNumbers)
            {
                if (isSubstringDivisible(n))
                {
                    sum += Convert.ToInt64(n);
                }
            }
            
            return sum.ToString();
        }

        private static bool isSubstringDivisible(string s)
        {
            for (int i = 1; i < s.Length-2; i++)
            {
                if (Convert.ToInt64(s.Substring(i, 3)) % primeNumbers[i-1] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}