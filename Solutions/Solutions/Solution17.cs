using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution17 : ISolution
    {
        private string[] units = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private string[] tens = new string[] { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        private string[] teens = new string[] { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private string hundred = "hundred";
        private string thousand = "thousand";
        private string and = "and";

        public string GetSolution()
        {
            return Enumerable.Range(1, 1000).Sum(n => GetNumberInLetters(n).Count()).ToString();
        }

        private string GetNumberInLetters(int i) {
            var sb = new StringBuilder();
            var digits = i.ToString().PadLeft(4, '0').Select(o => int.Parse(o.ToString())).ToArray();
            if (digits[0] > 0) {
                sb.Append(units[digits[0]-1]);
                sb.Append(thousand);
            }
            if (digits[1] > 0 ) {
                sb.Append(units[digits[1]-1]);
                sb.Append(hundred);
                if (digits[2] > 0 || digits[3] > 0) sb.Append(and);
            }
            if (digits[2] == 1 && digits[3] != 0) {
                sb.Append(teens[digits[3]-1]);
            } else {
                if (digits[2] > 0) sb.Append(tens[digits[2]-1]);
                if (digits[3] != 0) sb.Append(units[digits[3]-1]);
            }
            
            return sb.ToString();
        }
    }
}