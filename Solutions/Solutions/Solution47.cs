using System.Collections.Generic;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution47 : ISolution
    {        
        public string GetSolution()
        {
            var i = 1;

            var consecutiveCount = 0;
            while (true)
            {
                var primeFactors = Factors.GetPrimeFactors(i);

                if (primeFactors.Distinct().Count()==4)
                {
                    consecutiveCount++;
                } else {
                    consecutiveCount = 0;
                }

                if (consecutiveCount == 4)
                {
                    return (i-3).ToString();
                }

                i++;
            }
        }
    }
}