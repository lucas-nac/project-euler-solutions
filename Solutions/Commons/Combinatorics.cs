using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Commons
{
    public static class Combinatorics
    {
        public static IEnumerable<string> GetVariations(string elements, int n)
        {
            if (n == 1) return elements.Select(e => e.ToString());

            var variations = new List<string>();
            foreach (var v in GetVariations(elements, n-1))
            {
                foreach (var e in elements)
                {
                    variations.Add(e+v);          
                }
            }

            return variations.ToList();
        }
    }
}