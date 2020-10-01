using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution24 : ISolution
    {
        public string GetSolution()
        {
            long target = 1000000;
            var digits = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var answer = new StringBuilder();

            while (digits.Any()) {
                var index = 0;
                var permutations = GetFactorial(digits.Count - 1);

                while (permutations < target) {
                    target -= permutations;
                    index++;
                }

                answer.Append(digits[index]);
                digits.RemoveAt(index);
            }

            return answer.ToString();
        }

        private long GetFactorial(long n) {
            return n <= 1 ? 1 : n * GetFactorial(n-1);
        }
    }    
}