using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution37 : ISolution
    {
        private static IList<long> primeNumbers = PrimeNumbers.GetPrimeNumbersBelow(1000000).ToList();

        public string GetSolution()
        {
            var rightTruncatablePrimes = getRightTruncatablePrimes();
            return rightTruncatablePrimes.Where(p => isLeftTruncatable(p)).Sum(p => p).ToString();
        }

        private static IList<long> getRightTruncatablePrimes()
        {
            var two = addTrailingDigits(2);
            var three = addTrailingDigits(3);
            var five = addTrailingDigits(5);
            var seven = addTrailingDigits(7);
            return two.Concat(three).Concat(five).Concat(seven).ToList();
        }

        private static IList<long> addTrailingDigits(long n)
        {
            var result = new List<long>();
            n *= 10;

            foreach (var m in new int[]{1, 3, 7, 9})
            {
                if (primeNumbers.Contains(n+m))
                {
                    result.Add(n+m);
                    result.AddRange(addTrailingDigits(n+m));
                }
            }

            return result;
        }

        private static bool isLeftTruncatable(long n)
        {

            return n / 10 == 0 ? primeNumbers.Contains(n) : primeNumbers.Contains(n) && isLeftTruncatable(Convert.ToInt64(String.Concat(n.ToString().Skip(1))));
        }
    }
}