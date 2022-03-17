using System;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution719 : ISolution
    {
        public string GetSolution()
        {
            var sum = (long)0;

            for (long i = 2; i <= 1000000; i++)
            {
                var power = i*i;
                if (splittedSumEqualsSqrt(power.ToString(), i)) sum+=power;
            }

            return sum.ToString();
        }

        public bool splittedSumEqualsSqrt(string digits, long n)
        {
            for (int i = 1; i <= digits.Length; i++)
            {
                var diff = n - Convert.ToInt64(digits.Substring(0, i));

                if (diff < 0) return false;

                var newDigits = digits.Substring(i);
                if (diff == 0)  return newDigits.Length == 0 || Convert.ToInt64(newDigits) == 0;
                
                if (splittedSumEqualsSqrt(newDigits, diff))  return true;
            }

            return false;
        }
    }
}