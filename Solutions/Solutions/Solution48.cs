using System;
using System.Linq;
using System.Numerics;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution48 : ISolution
    {        
        public string GetSolution()
        {
            var sum = new BigInteger();

            for (int i = 1; i <= 1000; i++)
            {
                sum += BigInteger.Pow(i, i);
            }

            return String.Concat(sum.ToString().TakeLast(10)).TrimStart('0');
        }
    }    
}