using System.IO;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution79 : ISolution
    {
        public string GetSolution()
        {
            var lines = File.ReadAllLines("./assets/p079_keylog.txt").ToList();
            var code = string.Empty;

            while (lines.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    var digit = (char)(i + '0');
                    var isFirst = lines.Any(l => l[0] == digit);
                    var isSecond = lines.Where(l => l.Length > 1).Any(l => l[1] == digit);
                    var isThird = lines.Where(l => l.Length > 2).Any(l => l[2] == digit);

                    if (isFirst && !isSecond && !isThird)
                    {
                        code += digit.ToString();
                        lines = lines.Select(l => l.Replace($"{digit}", string.Empty)).Where(l => l != string.Empty).ToList();
                        break;
                    }
                }
            }   

            return code;
        }
    }    
}