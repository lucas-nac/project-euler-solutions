using System;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution30 : ISolution
    {
        public string GetSolution()
        {
            var sum = 0;

            for (int i = 2; i < 1000000; i++)
            {
                if (SumDigitsPowers(i) == i) sum += i;
            }
            
            return sum.ToString();
        }

        private int SumDigitsPowers(int i) {
            return (int)i.ToString().Sum(n => Math.Pow(int.Parse(n.ToString()), 5));
        }
    }    
}