using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;
using Solutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution41 : ISolution
    {
        private static IList<long> primeNumbers = PrimeNumbers.GetPrimeNumbersBelow(7654321).OrderByDescending(n => n).ToList();
        
        public string GetSolution()
        {
            foreach (var n in primeNumbers)
            {
                var nString = n.ToString();
                if (!PandigitalNumbers.IsPandigital(nString)) continue;
                return n.ToString();
            }

            return string.Empty;
        }
    }    
}