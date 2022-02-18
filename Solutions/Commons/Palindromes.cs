using System.Numerics;

namespace Solutions.Commons
{
    public static class Palindromes
    {
        public static bool IsPalindrome(BigInteger n) {
            var number = n.ToString();

            return IsPalindrome(number);
        }

        public static bool IsPalindrome(int n) {
            var number = n.ToString();

            return IsPalindrome(number);
        }

        public static bool IsPalindrome(string s) {
            for (int i = 0; i <= s.Length/2; i++) {
                var opposedIndex = s.Length-1-i;
                if (s[i] != s[opposedIndex]) return false;
            }

            return true;
        }
    }
}