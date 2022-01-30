using System;
using System.Collections.Generic;
using System.Linq;
using Solutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution36 : ISolution
    {        
        public string GetSolution()
        {
            var palindromes = new List<int>();

            for (int i = 1; i < 1000000; i++)
            {
                if (Palindromes.IsPalindrome(i))
                {
                    palindromes.Add(i);
                }
            }

            var doubleBasePalindromes = new List<int>();

            foreach (var p in palindromes)
            {
                if (Palindromes.IsPalindrome(Convert.ToString(p, 2)))
                {
                    doubleBasePalindromes.Add(p);
                }
            }
            
            return doubleBasePalindromes.Sum(p => p).ToString();
        }
    }    
}