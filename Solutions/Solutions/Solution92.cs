using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution92 : ISolution
    {        
        public string GetSolution()
        {
            var count = 0;

            for (int i = 1; i < 10000000; i++)
            {
                var n = i;
                while (n != 1 && n != 89)
                {
                    n = (int)n.ToString().Select(p => Math.Pow(p-'0', 2)).Sum(p => p);
                }
                if (n == 89) count++;
            }

            return count.ToString();
        }
    }    
}