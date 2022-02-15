using System.Collections.Generic;
using System.Linq;

namespace Solutions.Commons
{
    public class PandigitalNumbers
    {
        public static bool IsPandigital(string s, bool includeZero) {
            if (!includeZero && s.Contains('0')) return false;

            var max = includeZero ? s.Length : s.Length + 1;
            for (int i = includeZero ? 0 : 1; i < s.Length; i++)
            {
                var c = '0' + i;
                if (s.Count(d => d == c) != 1) return false;
            }

            return true;
        }

        public static IEnumerable<string> GetNPandigitalNumbers(int n, bool withZero) {
            var digits = string.Empty;

            if (withZero) digits += "0";

            var next = 1;
            while (digits.Length != n)
            {
                digits += next;
                next++;
            }

            return getPermutations(digits).Where(p => p[0] != '0').ToList();
        }

        private static IList<string> getPermutations(string items)
        {
            if (items.Length == 2) return new List<string>() {items, $"{items[1]}{items[0]}"};

            var result = new List<string>();
            foreach (var c in items)
            {
                result.AddRange(getPermutations(new string(items.Replace($"{c}", ""))).Select(p => $"{c}{p}"));
            }

            return result;
        }
    }
}