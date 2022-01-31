using System;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution35 : ISolution
    {
        public string GetSolution()
        {
            var count = 2;
            var primeNumbers = PrimeNumbers.GetPrimeNumbersBelow(1000000).ToList();
            var hasEvenDigit = primeNumbers.Where(n => n.ToString().IndexOfAny("024568".ToCharArray()) != -1);
            primeNumbers = primeNumbers.Except(hasEvenDigit).ToList();

            while (primeNumbers.Count() > 0)
            {
                var n = primeNumbers.ElementAt(0);
                primeNumbers.Remove(n);

                var originalN = n.ToString();
                var rotatedN = rotate(originalN);
                var isCircularPrime = true;

                var subCount = 1;
                while (rotatedN != originalN)
                {
                    var parsedN = Convert.ToInt64(rotatedN);
                    if (!primeNumbers.Contains(parsedN))
                    {
                        isCircularPrime = false;
                    }
                    rotatedN = rotate(rotatedN);
                    primeNumbers.Remove(parsedN);
                    subCount++;
                }

                if (isCircularPrime)
                {
                    count += subCount;
                }
            }

            return count.ToString();
        }

        private static string rotate(string n)
        {
            var stringN = n.ToString();
            return String.Concat((stringN + stringN[0]).Skip(1));
        }
    }
}