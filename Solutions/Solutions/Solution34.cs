using System.Collections.Generic;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution34 : ISolution
    {
        private static Dictionary<char, int> factorials = new Dictionary<char, int>() {
            { '0', 1 },
            { '1', 1 },
            { '2', 2 },
            { '3', 6 },
            { '4', 24 },
            { '5', 120 },
            { '6', 720 },
            { '7', 5040 },
            { '8', 40320 },
            { '9', 362880 },
        };

        public string GetSolution()
        {
            var sum = 0;

            for (int i = 10; i <= 2540160; i++)
            {
                var iSum = 0;

                foreach (var d in i.ToString())
                {
                    iSum += factorials[d];
                }

                if (iSum == i)
                {
                    sum += i;
                }
            }

            return sum.ToString();
        }
    }    
}