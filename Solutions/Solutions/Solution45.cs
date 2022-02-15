using Solutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution45 : ISolution
    {        
        public string GetSolution()
        {
            var n = 287;
            while (true)
            {
                var t = n * (2*n - 1);

                if (PentagonalNumbers.IsPentagonal(t))
                {
                    return t.ToString();
                }

                n += 2;
            }
        }
        
        
    }    
}