using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution38 : ISolution
    {
        public string GetSolution()
        {
            var pandigitals = new List<long>();
            for (int i = 9; i < 9999; i++)
            {
                var number = string.Empty;

                var m = 1;
                while (number.Length < 9)
                {
                    number += (i*m).ToString();
                    m++;
                }

                if (!number.Contains('0') && number.Length == 9 && number.Distinct().Count() == 9)
                {
                    pandigitals.Add(Convert.ToInt64(number));
                }

                if (i.ToString().Distinct().Count() == 1)
                {
                    i = (int)(9*Math.Pow(10, i.ToString().Count())) - 1;
                }
            }

            return pandigitals.Max().ToString();
        }
    }
}