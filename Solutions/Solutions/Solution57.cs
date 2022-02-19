using System;
using System.Linq;
using System.Numerics;
using Solutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution57 : ISolution
    {        
        public string GetSolution()
        {
            var count = 0;

            var numerator = new BigInteger(3);
            var denominator = new BigInteger(2);

            for (int i = 0; i < 1000; i++)
            {
                var newNumerator = numerator + 2*denominator;
                denominator = numerator + denominator;
                numerator = newNumerator;

                if (numerator.CountDigits() > denominator.CountDigits()) count++;
            }

            return count.ToString();
        }
    }
}