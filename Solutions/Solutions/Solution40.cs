using System;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution40 : ISolution
    {
        private readonly int[] digits = new int[7] { 1, 10, 100, 1000, 10000, 100000, 1000000 };
        
        public string GetSolution()
        {
            return digits.Aggregate((long)1, (acc, n) => acc *= GetChampernownesNthDigit(n)).ToString();
        }

        private int GetChampernownesNthDigit(long n) {
            var digits = 1;
            long length = 9;

            if (n <= length) return (int)n;
            n--;

            while (n > length) {
                digits++;
                n -= length;
                var limit = int.Parse(new string('9', digits));
                length = ( limit - (limit/10)) * digits;
            }

            var number = Math.Pow(10, digits-1) + (n / digits);
            return int.Parse(number.ToString()[(int)(n % digits)].ToString());
        }
    }    
}