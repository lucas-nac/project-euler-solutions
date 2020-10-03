using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution27 : ISolution
    {
        long[] primeNumbers = PrimeNumbers.GetPrimeNumbersBelow(1000).ToArray();

        public string GetSolution()
        {
            int maxA = 0, maxB = 0, maxCount = int.MinValue;

            foreach (var a in Enumerable.Range(-999, 1999)) 
            {
                foreach (var b in primeNumbers)
                {
                    var i = 0;
                    while (IsPrime((i*i) + (i*a) + b)) i++;
                    if (i > maxCount) {
                        maxA = a;
                        maxB = (int)b;
                        maxCount = i;
                    }
                }
            }

            return (maxA*maxB).ToString();
        }
        
        private bool IsPrime(long n) {
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                if (primeNumbers[i] == n) return true;
            }
            return false;
        }
    }    
}