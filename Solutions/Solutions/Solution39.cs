using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution39 : ISolution
    {
        private static Dictionary<Tuple<int,int>, int> sides = new Dictionary<Tuple<int,int>, int>();

        public string GetSolution()
        {
            for (int i = 1; i < 1000; i++)
            {
                for (int j = i; j < 1000; j++)
                {
                    var legs = new Tuple<int, int>(i, j);

                    if (sides.ContainsKey(legs))
                    {

                    } else {
                        var hypotenuse = Math.Sqrt(i*i + j*j);
                        if (hypotenuse % 1 != 0)
                        {
                            hypotenuse = 0;
                        } else {
                            
                        }
                        sides[legs] = (int)hypotenuse;
                    }
                }
            }

            return sides.Where(s => s.Value != 0).
                Select(s => s.Key.Item1 + s.Key.Item2 + s.Value).
                Where(s => s <= 1000).
                GroupBy(s => s).
                OrderByDescending(s => s.Count()).
                First().Key.ToString();
        }
    }
}