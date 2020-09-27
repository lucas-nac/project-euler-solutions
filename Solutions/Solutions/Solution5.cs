using System;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution5 : ISolution
    {
        public string GetSolution()
        {
            var max = 20;

            var primes = PrimeNumbers.GetPrimeNumbersBelow(max);
            long product = 1;
            foreach (var n in primes)
            {
                var power = Math.Floor(Math.Log(max)/Math.Log(n));
                product *= (long)Math.Pow(n, power);
            }
            
            return product.ToString();
        }
    }
}