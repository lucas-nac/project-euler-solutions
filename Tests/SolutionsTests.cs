using ProjectEulerSolutions.Solutions;
using Xunit;

namespace ProjectEulerSolutions.Tests
{
    public class SolutionsTests
    {
        [Fact]
        public void Solution1()
        {
            Assert.Equal("233168", new Solution1().GetSolution());
        }

        [Fact]
        public void Solution2()
        {
            Assert.Equal("4613732", new Solution2().GetSolution());
        }

        [Fact]
        public void Solution3()
        {
            Assert.Equal("6857", new Solution3().GetSolution());
        }

        [Fact]
        public void Solution4()
        {
            Assert.Equal("906609", new Solution4().GetSolution());
        }

        [Fact]
        public void Solution5()
        {
            Assert.Equal("232792560", new Solution5().GetSolution());
        }

        [Fact]
        public void Solution6()
        {
            Assert.Equal("25164150", new Solution6().GetSolution());
        }

        [Fact]
        public void Solution7()
        {
            Assert.Equal("104743", new Solution7().GetSolution());
        }

        [Fact]
        public void Solution8()
        {
            Assert.Equal("23514624000", new Solution8().GetSolution());
        }

        [Fact]
        public void Solution9()
        {
            Assert.Equal("31875000", new Solution9().GetSolution());
        }

        [Fact]
        public void Solution10()
        {
            Assert.Equal("142913828922", new Solution10().GetSolution());
        }

        [Fact]
        public void Solution11()
        {
            Assert.Equal("70600674", new Solution11().GetSolution());
        }

        [Fact]
        public void Solution12()
        {
            Assert.Equal("76576500", new Solution12().GetSolution());
        }

        [Fact]
        public void Solution13()
        {
            Assert.Equal("5537376230", new Solution12().GetSolution());
        }
    }
}
