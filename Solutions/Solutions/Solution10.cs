using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution10 : ISolution
    {
        public string GetSolution()
        {
            return PrimeNumbers.GetPrimeNumbersBelow(2000000).Sum().ToString();
        }
    }
}