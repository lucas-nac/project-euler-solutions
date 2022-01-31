using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution42 : ISolution
    {
        private static Dictionary<int, bool> triangleNumbers = new Dictionary<int, bool>();

        public string GetSolution()
        {
            var words = File.ReadAllLines("./assets/p042_words.txt")[0].Split(',').Select(w => w.Substring(1, w.Length-2));
            var count = 0;

            foreach (var w in words)
            {
                var wordValue = w.Sum(c => c - '@');
                if (isTriangleWord(wordValue))
                {
                    count++;
                }
            }

            return count.ToString();
        }

        private static bool isTriangleWord(int n)
        {
            if (triangleNumbers.ContainsKey(n)) return triangleNumbers[n];

            var t =  (Math.Sqrt(1+(8*n)) - 1) / 2;
            var isTriangle = t % 1 == 0;

            triangleNumbers[n] = isTriangle;

            return isTriangle;
        }
    }    
}