using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution1 : ISolution
    {
        public string GetSolution()
        {
            return Enumerable.Range(1, 999).Where(n => n % 3 == 0 || n % 5 == 0).Sum().ToString();
        }
    }
}