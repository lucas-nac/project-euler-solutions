using System;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution25 : ISolution
    {
        public string GetSolution()
        {
            //Binet's formula
            return Math.Ceiling(((999 + Math.Log10(5)/2) / Math.Log10((1+Math.Sqrt(5))/2))).ToString();
        }
    }    
}