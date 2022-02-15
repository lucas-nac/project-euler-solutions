using Solutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution44 : ISolution
    {
        public string GetSolution()
        {
            var min = int.MaxValue;

            for (int i = 1; i < 5000; i++)
            {
                var p1 = i * (3 * i - 1) / 2;

                for (int j = i + 1; j < 5000; j++)
                {
                    var p2 = j * (3 * j - 1) / 2;

                    var difference = p2 - p1;
                    if (PentagonalNumbers.IsPentagonal(p1 + p2) && PentagonalNumbers.IsPentagonal(difference) && difference < min)
                    {
                        min = difference;
                    }
                }
            }

            return min.ToString();
        }
    }
}