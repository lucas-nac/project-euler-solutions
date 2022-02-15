using System;

namespace Solutions.Commons
{
    public class PentagonalNumbers
    {
        public static bool IsPentagonal(long n)
        {
            var p = (Math.Sqrt(1 + 24*n) + 1) / 6;
            return p % 1 == 0;
        }
    }
}