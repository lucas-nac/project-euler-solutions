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
                    if (IsPalindrome(product) && product > maxPalindrome) {
                        maxPalindrome = product;
                    } 
                }
            }
            return maxPalindrome.ToString();
        }

        private bool IsPalindrome(int n) {
            var number = n.ToString();

            for (int i = 0; i <= number.Length/2; i++) {
                var opposedIndex = number.Length-1-i;
                if (number[i] != number[opposedIndex]) return false;
            }

            return true;
        }
    }
}