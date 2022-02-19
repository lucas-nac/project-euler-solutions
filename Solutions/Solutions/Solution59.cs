using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProjectEulerSolutions.Commons;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution59 : ISolution
    {
        public string GetSolution()
        {
            var baseText = new string(File.ReadAllLines("./assets/p059_cipher.txt")[0].Split(',').Select(c => (char)Convert.ToInt32(c)).ToArray());
            var keys = Combinatorics.GetVariations("abcdefghijklmnopqrstuvxyz", 3);

            foreach (var key in keys)
            {
                var text = string.Empty;
                for (int i = 0; i < baseText.Length; i++)
                {
                    text += (char)(baseText[i] ^ key[i%3]);
                }

                if (text.Contains(" the ") && text.Contains(" is ")) return text.Sum(c => c).ToString();
            }

            return string.Empty;
        }
    }
}