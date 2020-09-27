using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution7 : ISolution
    {
        public string GetSolution()
        {
            return PrimeNumbers.GetNthPrimeNumber(10001).ToString();
        }
    }
}