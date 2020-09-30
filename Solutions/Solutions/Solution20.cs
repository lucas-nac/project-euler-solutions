using System;
using System.Linq;
using System.Numerics;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution20 : ISolution
    {
        public string GetSolution()
        {
            return Enumerable.Range(1, 100).Aggregate(new BigInteger(1), (acc, n) => acc *= n).ToString().Select(d => int.Parse(d.ToString())).Sum().ToString();
        }
    }    
}