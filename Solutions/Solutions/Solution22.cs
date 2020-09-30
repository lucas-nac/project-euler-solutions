using System;
using System.IO;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution22 : ISolution
    {
        public string GetSolution()
        {
            var names = File.ReadAllLines("./assets/names.txt")[0].Replace("\"", string.Empty).Split(',').OrderBy(n => n).ToArray();

            var score = 0;
            for (int i = 0; i < names.Length; i++)
            {
                score += (i+1)*GetNameScore(names[i]);    
            }

            return score.ToString();
        }

        public int GetNameScore(string name) {
            return name.Sum(c => c - '@');
        }
    }    
}