using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution29 : ISolution
    {
        public string GetSolution()
        {
            var powers = new List<double>();

            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    double power = Math.Pow(a, b);
                    if (!powers.Contains(power))
                    {
                        powers.Add(power);
                    }
                }
            }
            
            return powers.Count().ToString();
        }
    }    
}