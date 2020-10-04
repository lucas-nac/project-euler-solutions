using System;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution31 : ISolution
    {
        private readonly int[] allCoins = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };

        public string GetSolution()
        {            
            return GetPossibleWays(200, allCoins).ToString();
        }

        private int GetPossibleWays(int i, int[] coins) {
            if (i == 0) return 1;

            var ways = 0;
            foreach (var coin in coins)
            {
                if(i - coin >= 0) {
                    ways += GetPossibleWays(i-coin, coins.Skip(coins.ToList().FindIndex(c => c == coin)).ToArray());
                }
            }

            return ways;         
        }
    }    
}