using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution46 : ISolution
    {
        private static IList<long> primeNumbers = PrimeNumbers.GetPrimeNumbersBelow(1000000).ToList();
        
        public string GetSolution()
        {
            for (int i = 9; i < 1000000; i+=2)
            {
                if (primeNumbers.Contains(i)) continue;

                var found = false;

                foreach (var prime in primeNumbers)
                {
                    if (prime > i) break;

                    for (int j = 1; j*j <= i; j++)
                    {
                        var n = prime + (2*j*j);
                        if (n == i)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found) break;
                }

                if (!found) return i.ToString();
            }

            return string.Empty;
        }
    }
}