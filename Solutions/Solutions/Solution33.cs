using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution33 : ISolution
    {        
        public string GetSolution()
        {
            var fractions = new Dictionary<double, double>();
            for (double a = 1; a < 9; a++)
            {
                for (double b = a + 1; b < 10; b++)
                {
                    for (double c = 1; c < 10; c++)
                    {
                        var fraction = a/b;
                        if ((10*c + a)/(10*c + b) == fraction) fractions[10*c + a] = 10*c + b;
                        if ((10*a + c)/(10*b + c) == fraction) fractions[10*a + c] = 10*b + c;
                        if ((10*a + c)/(10*c + b) == fraction) fractions[10*a + c] = 10*c + b;
                        if ((10*c + a)/(10*b + c) == fraction) fractions[10*c + a] = 10*b + c;
                    }
                }
            }

            var numerator = fractions.Keys.Aggregate(1.0, (acc, n) => acc *= n);
            var denominator = fractions.Values.Aggregate(1.0, (acc, n) => acc *= n);
            var gcd = 0;

            for (int i = 2; i <= numerator; i++)
            {
                if (numerator % i == 0 && denominator % i == 0) gcd = i;
            }
            
            return (denominator / gcd).ToString();
        }
    }    
}