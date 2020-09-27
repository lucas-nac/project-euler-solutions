using System.Collections.Generic;
using System.Linq;

namespace project_euler_solutions.common
{
    public static class PrimeNumbers
    {
        public static IEnumerable<long> GetPrimeNumbersBelow(long n) {
            var numbers = new Dictionary<long, bool>();
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
                    }
                }
            }            

            return numbers.Where(kv => kv.Value).Select(kv => kv.Key);
        }
    }
}