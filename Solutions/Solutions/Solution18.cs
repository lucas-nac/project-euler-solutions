using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution18 : ISolution
    {
        private string[] lines = new string[] {
            "75",
            "95 64",
            "17 47 82",
            "18 35 87 10",
            "20 04 82 47 65",
            "19 01 23 75 03 34",
            "88 02 77 73 07 63 67",
            "99 65 04 28 06 16 70 92",
            "41 41 26 56 83 40 80 70 33",
            "41 48 72 33 47 32 37 16 94 29",
            "53 71 44 65 25 43 91 52 97 51 14",
            "70 11 33 28 77 73 17 78 39 68 17 57",
            "91 71 52 38 17 14 91 43 58 50 27 29 48",
            "63 66 04 68 89 53 67 30 73 16 69 87 40 31",
            "04 62 98 27 23 09 70 98 73 93 38 53 60 04 23"
        };

        public string GetSolution()
        {
            var triangle = new Triangle(lines);

            return triangle.GetMaximumSum().ToString();
        }

        protected class Triangle
        {
            private TriangleNumber root;

            public Triangle(string[] lines) {
                root = new TriangleNumber { Value = int.Parse(lines[0]) };

                var previousLevel = new TriangleNumber[] { root };
                foreach (var line in lines.Skip(1))
                {
                    var numbers = line.Split(' ').Select(x => int.Parse(x)).ToArray();
                    var currentLevel = numbers.Select(n => new TriangleNumber() { Value = n}).ToArray();

                    for (int i = 0; i < currentLevel.Length; i++)
                    {
                        if (i != currentLevel.Length - 1) previousLevel[i].Left = currentLevel[i];
                        if (i != 0) previousLevel[i - 1].Right = currentLevel[i];
                    }

                    previousLevel = currentLevel;
                }
            }

            public long GetMaximumSum() {
                return root.GetMaximumSum();
            }
        }

        protected class TriangleNumber
        {
            public int Value { get; set; }
            public TriangleNumber Left { get; set; }
            public TriangleNumber Right { get; set; }

            public long GetMaximumSum() {
                return Left == null || Right == null ? Value : Value + Math.Max(Left.GetMaximumSum(), Right.GetMaximumSum());
            }
        }
    }    
}