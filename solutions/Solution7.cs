using project_euler_solutions.common;

namespace project_euler_solutions.solutions
{
    public class Solution7 : ISolution
    {
        public string GetSolution()
        {
            return PrimeNumbers.GetNthPrimeNumber(10001).ToString();
        }
    }
}