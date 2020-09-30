using System;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution21 : ISolution
    {
        public string GetSolution()
        {
            var totalSum = 0;

            for (int i = 2; i < 10000; i++)
            {
                var divisorsSum = Factors.GetProperDivisors(i).Sum();
                var otherDivisorsSum = Factors.GetProperDivisors(divisorsSum).Sum();
                
                if (i != divisorsSum && otherDivisorsSum < 10000 && otherDivisorsSum == i) {
                    Console.WriteLine(i + " " + divisorsSum);
                    totalSum += i;
                }
            }

            return totalSum.ToString();
        }
    }    
}