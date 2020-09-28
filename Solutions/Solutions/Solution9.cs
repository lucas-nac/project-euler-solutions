using System;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution9 : ISolution
    {
        public string GetSolution()
        {
            for (int a = 1; a < 1000; a++) {
                for (int b = a + 1; a + b <= 1000; b++) {
                    var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    
                    if (c == Math.Floor(c) && a + b + c == 1000) {
                        return (a*b*c).ToString();
                    }
                }
            }

            return string.Empty;
        }
    }
}