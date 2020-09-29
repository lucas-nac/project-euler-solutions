using System;
using System.Collections.Generic;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution15 : ISolution
    {
        private int height = 20, width = 20;

        private IDictionary<string, long> calculatedRoutes = new Dictionary<string, long>();

        public string GetSolution()
        {
            return CountRoutes(0, 0).ToString();
        }

        private long CountRoutes(int x, int y) {
            if (x == width || y == height) return 0;
            if (calculatedRoutes.ContainsKey($"{x},{y}")) return calculatedRoutes[$"{x},{y}"];

            long routes = x == 0 && y == 0 ? 2 : 1;
            routes += CountRoutes(x + 1, y) + CountRoutes(x, y + 1);
            calculatedRoutes[$"{x},{y}"] = routes;
            return routes;
        }
    }
}