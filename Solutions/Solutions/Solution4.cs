using Solutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution4 : ISolution
    {
        public string GetSolution()
        {
            var maxPalindrome = 0;
            for (int i = 999; i > 100; i--) {
                if (i*i < maxPalindrome) break;
                for (int j = i; j > 100; j--) {
                    var product = i*j;
                    if (Palindromes.IsPalindrome(product) && product > maxPalindrome) {
                        maxPalindrome = product;
                    } 
                }
            }
            return maxPalindrome.ToString();
        }

        
    }
}