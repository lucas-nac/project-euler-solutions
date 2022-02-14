using System;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution45 : ISolution
    {        
        public string GetSolution()
        {
            var n = 287;
            while (true)
            {
                var t = n * (2*n - 1);

                if (isPentagonal(t))
                {
                    return t.ToString();
                }

                n += 2;
            }
        }
        
        private static bool isPentagonal(long n)
        {
            var p = (Math.Sqrt(1 + 24*n) + 1) / 6;
            return p % 1 == 0;
        }
    }    
}