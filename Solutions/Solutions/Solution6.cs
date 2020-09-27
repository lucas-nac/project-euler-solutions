using System;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution6 : ISolution
    {
        public string GetSolution()
        {
            var max = 100;
            var sumOfSquares = (long)Enumerable.Range(1, max).Sum(n => Math.Pow(n, 2));
            var squareOfSum = (long)Math.Pow(Enumerable.Range(1, max).Sum(), 2);
            return (squareOfSum-sumOfSquares).ToString();
        }
    }
}