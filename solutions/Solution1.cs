using System.Linq;

namespace project_euler_solutions.solutions
{
    public class Solution1 : ISolution
    {
        public string GetSolution()
        {
            return Enumerable.Range(1, 999).Where(n => n % 3 == 0 || n % 5 == 0).Sum().ToString();
        }
    }
}