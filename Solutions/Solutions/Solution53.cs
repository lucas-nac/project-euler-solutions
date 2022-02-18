using System.Numerics;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution53 : ISolution
    {        
        public string GetSolution()
        {
            var count = 0;

            for (int n = 23; n <= 100; n++)
            {
                for (int r = 1; r <= n; r++)
                {
                    var c = factorial(n)/(factorial(r)*factorial(n-r));
                    if (c > 1000000) count ++;
                }
            }

            return count.ToString();
        }

        private static BigInteger factorial(int n) {
            var result = (BigInteger)1;
            for (int i = 2; i <= n; i++) {
                result *= i;
            }
            return result;
        }
    }    
}