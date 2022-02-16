using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution52 : ISolution
    {        
        public string GetSolution()
        {
            var start = 10;
            var end = 99;

            while (true)
            {
                for (int i = start; i*6 < end; i++)
                {
                    var numbers = new List<int>();

                    for (int j = 1; j <= 6; j++)
                    {
                        numbers.Add(i*j);
                    }

                    if (numbers.Select(n => new string(n.ToString().OrderBy(c => c).ToArray())).Distinct().Count() == 1) return i.ToString();
                }

                start *= 10;
                end = end*10 + 9;
            }
        }
    }    
}