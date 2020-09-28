using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution3 : ISolution
    {        
        public string GetSolution()
        {
            return Factors.GetFactors(600851475143).Max().ToString();
        }
    }
}