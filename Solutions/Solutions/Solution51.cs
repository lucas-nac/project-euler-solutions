using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;
using Solutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution51 : ISolution
    {
        private static IList<IGrouping<int, long>> primeNumbersByDigits = PrimeNumbers.GetPrimeNumbersBelow(1000000).GroupBy(p => p.CountDigits()).Where(d => d.Key >= 2).ToList();
        
        public string GetSolution()
        {
            foreach (var byDigits in primeNumbersByDigits)
            {
                var variations = Combinatorics.GetVariations("X0", byDigits.Key).SkipLast(1).Skip(1);
                var primes = byDigits.Select(p => p.ToString()).ToList();

                var min = int.MaxValue;

                foreach (var v in variations)
                {
                    var families = primes.GroupBy(p => maskIfValid(p, v)).Where(g => g.Key != string.Empty && g.Count() >= 8);

                    foreach (var family in families)
                    {
                        var smallest = Convert.ToInt32(family.ElementAt(0));
                        if (smallest < min) min = smallest;
                    }                    
                }

                if (min != int.MaxValue) return min.ToString();
            }

            return "";
        }

        private static string maskIfValid(string number, string mask)
        {
            var masked = string.Empty;
            var changed = string.Empty;

            for (int i = 0; i < mask.Length; i++)
            {
                if (mask[i] == 'X') {
                    masked += 'X';
                    changed += number[i];
                } else {
                    masked += number[i];
                }
            }

            return changed.Distinct().Count() == 1 ? masked : string.Empty;
        }
    }
}