using System;
using System.Linq;
using System.Numerics;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution56 : ISolution
    {        
        public string GetSolution()
        {
            var max = int.MinValue;

            for (int i = 1; i < 100; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    var sum = BigInteger.Pow(i, j).ToString().Sum(d => d-'0');
                    if (sum > max) max = sum;
                }
            }

            return max.ToString();
        }
    }    
}