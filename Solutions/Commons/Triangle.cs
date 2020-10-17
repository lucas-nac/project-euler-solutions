using System;
using System.Linq;

namespace Solutions.Commons
{
    public class Triangle
    {
        private int[][] numbers;

        public Triangle(string[] lines) {
            this.numbers = lines.Select(l => l.Split(' ').Select(n => int.Parse(n)).ToArray()).ToArray();
        }

        public long GetMaximumSum() {
            for (int i = numbers.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    numbers[i][j] += Math.Max(numbers[i+1][j], numbers[i+1][j+1]);
                }
            }

            return numbers[0][0];
        }
    }
}