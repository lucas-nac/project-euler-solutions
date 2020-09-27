using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Commons
{
    public static class PrimeNumbers
    {
        private static Dictionary<long, bool> numbers = new Dictionary<long, bool>();

        public static IEnumerable<long> GetPrimeNumbersBelow(long n) {
            var highestCalculatedNumber = numbers.Any() ? (long)numbers?.Max(kv => kv.Key) : 0;

            if (n >= 2) {
                numbers[2] = true;

                for (long i = 3; i < n; i+=2) {
                    if (!numbers.ContainsKey(i)) {
                        numbers[i] = true;
                        var multiple = i+i;
                        while (multiple <= n) {
                            numbers[multiple] = false;
                            multiple += i;
                        }
                    } else if (numbers[i]) {
                        var multiple = ((highestCalculatedNumber/i)*i)+i;
                        while (multiple <= n) {
                            numbers[multiple] = false;
                            multiple += i;
                        }
                    }
                }
            }            

            return numbers.Where(kv => kv.Value).Select(kv => kv.Key);
        }

        public static long GetNthPrimeNumber(int i) {
            var max = i;
            var primeNumbers = GetPrimeNumbersBelow(max);

            while (primeNumbers.Count() < i) {
                max += i;
                primeNumbers = GetPrimeNumbersBelow(max);
            }

            return primeNumbers.ElementAt(i-1);
        }
    }
}