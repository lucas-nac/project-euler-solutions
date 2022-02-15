using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution50 : ISolution
    {
        private static IList<long> primeNumbers = PrimeNumbers.GetPrimeNumbersBelow(1000000).ToList();
        
        public string GetSolution()
        {
            var maxCount = 0;
            var max = (long)0;

            for (int i = 0; i < primeNumbers.Count(); i++)
            {
                var sum = primeNumbers[i];
                var count = 1;

                while (sum < 1000000)
                {
                    if (primeNumbers.Contains(sum) && count > maxCount)
                    {
                        maxCount = count;
                        max = sum;
                    }

                    if (i+count >= primeNumbers.Count()) break;
                    sum += primeNumbers[i+count];
                    count++;
                }
            }

            return max.ToString();
        }
    }
}