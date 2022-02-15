using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution49 : ISolution
    {
        private static IList<long> primeNumbers = PrimeNumbers.GetPrimeNumbersBelow(10000).ToList();
        
        public string GetSolution()
        {
            for (int i = 1488; i < 3340; i++)
            {
                var j = i+3330;
                var k = j+3330;

                if (!primeNumbers.Contains(i) || !primeNumbers.Contains(j) || !primeNumbers.Contains(k)) continue;

                var iDigits = new string(i.ToString().OrderBy(d => d).ToArray());
                if (iDigits == new string(j.ToString().OrderBy(d => d).ToArray()) && iDigits == new string(k.ToString().OrderBy(d => d).ToArray()))
                {
                    return $"{i}{j}{k}";
                }
            }

            return string.Empty;
        }
    }
}