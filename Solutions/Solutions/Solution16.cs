using System;
using System.Linq;
using System.Numerics;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution16 : ISolution
    {
        public string GetSolution()
        {
            var raised = BigInteger.Pow(2, 1000);

            return raised.ToString().Sum(c => c - '0').ToString();
        }
    }
}