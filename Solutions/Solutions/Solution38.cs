using System;
using System.Collections.Generic;
using System.Linq;
using Solutions.Commons;

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

                if (PandigitalNumbers.IsPandigital(number))
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