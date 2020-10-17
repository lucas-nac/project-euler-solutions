using System;
using System.IO;
using System.Linq;
using Solutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution67 : ISolution
    {
        public string GetSolution()
        {
            var lines = File.ReadAllLines("./assets/p067_triangle.txt");
            var triangle = new Triangle(lines);

            return triangle.GetMaximumSum().ToString();
        }
    }    
}