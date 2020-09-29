using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution14 : ISolution
    {
        private IDictionary<long, IEnumerable<long>> calculatedSequences = new Dictionary<long, IEnumerable<long>>() {
            { 1, new long[] {1} }
        };

        public string GetSolution()
        {
            var max = long.MinValue;
            long index = 0;

            for (long i = 1; i <= 1000000; i++) {
                var sequenceLength = GetCollatzSequence(i).Count();
                if (sequenceLength > max) {
                  max = sequenceLength;
                  index = i;
                }
            }

            return index.ToString();
        }

        public IEnumerable<long> GetCollatzSequence(long n) {
            if (calculatedSequences.ContainsKey(n)) return calculatedSequences[n];

            var next = n % 2 == 0 ? n / 2 : (3 * n) + 1;
            var sequence = GetCollatzSequence(next).Prepend(n);
            calculatedSequences[n] = sequence;

            return sequence;
        }
    }
}