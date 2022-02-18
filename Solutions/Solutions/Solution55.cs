using System;
using System.Linq;
using System.Numerics;
using Solutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution55 : ISolution
    {        
        public string GetSolution()
        {
            var count = 0;

            for (BigInteger n = 100; n <= 10000; n++)
            {
                if (isLychrelNumber(n)) count++;
            }

            return count.ToString();
        }

        private static bool isLychrelNumber(BigInteger n)
        {
            for (int i = 0; i < 50; i++)
            {
                var reversed = n.ToString().ToCharArray();
                Array.Reverse(reversed);
                n += BigInteger.Parse(new string(reversed));

                if (Palindromes.IsPalindrome(n)) return false;
            }

            return true;
        }
    }    
}