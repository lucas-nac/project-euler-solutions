using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution32 : ISolution
    {
        private IList<int> products = new List<int>();

        public string GetSolution()
        {            
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    var digits = $"{i}{j}{i*j}";
                    if (digits.Length > 9) break;
                    if (IsPandigital(digits)) products.Add(i*j);
                }
            }

            foreach (var item in products.Distinct())
            {
                Console.WriteLine(item);
            }

            return products.Distinct().Sum().ToString();
        }

        private bool IsPandigital(string digits) {
            return !digits.Contains('0') && digits.Distinct().Count() == 9;
        }
    }    
}