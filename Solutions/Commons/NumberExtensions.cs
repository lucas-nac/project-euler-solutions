using System.Linq;
using System.Numerics;

namespace Solutions.Commons
{
    public static class NumberExtensions
    {
        public static int CountDigits(this int n)
        {
            return n.ToString().Count();
        }

        public static int CountDigits(this long n)
        {
            return n.ToString().Count();
        }

        public static int CountDigits(this BigInteger n)
        {
            return n.ToString().Count();
        }
    }
}