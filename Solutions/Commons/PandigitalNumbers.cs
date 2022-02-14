using System.Linq;

namespace Solutions.Commons
{
    public class PandigitalNumbers
    {
        public static bool IsPandigital(string s) {
            if (s.Contains('0')) return false;

            for (int i = 1; i <= s.Length; i++)
            {
                var c = '0' + i;
                if (s.Count(d => d == c) != 1) return false;
            }

            return true;
        }
    }
}