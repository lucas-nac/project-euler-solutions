using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution28 : ISolution
    {
        public string GetSolution()
        {
            long answer = 1;

            for (int i = 3; i <= 1001; i+=2)
            {
                answer += Enumerable.Range(0, 4).Aggregate(0, (acc, n) => acc += (i*i)-(n*(i-1)));
            }

            return answer.ToString();
        }
    }    
}