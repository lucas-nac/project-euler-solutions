using System.Linq;
using ProjectEulerSolutions.Commons;
using Xunit;

namespace ProjectEulerSolutions.Tests
{
    public class CommonsTests
    {
        [Fact]
        public void GetPrimeNumbersBelow()
        {
            Assert.Equal(25, PrimeNumbers.GetPrimeNumbersBelow(100).Count());
        }

        [Fact]
        public void GetNthPrimeNumber()
        {
            Assert.Equal(7919, PrimeNumbers.GetNthPrimeNumber(1000));
        }

        [Fact]
        public void GetPrimeFactors()
        {
            Assert.Equal(6, Factors.GetPrimeFactors(1000).Count());
        }
    }
}
