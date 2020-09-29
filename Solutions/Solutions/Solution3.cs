using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution3 : ISolution
    {        
        public string GetSolution()
        {
            return Factors.GetPrimeFactors(600851475143).Max().ToString();
        }
    }
}