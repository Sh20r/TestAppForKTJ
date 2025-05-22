using Catalana;
using System.Numerics;

namespace TestProject
{
    public class UnitTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        [InlineData(4, 14)]
        [InlineData(5, 42)]
        [InlineData(10, 16796)]
        [InlineData(15, 9694845)]
        public void ValidInputs_ReturnCorrectCatalan(int n, int expected)
        {
            var result = Class1.CountPairs(n);
            Assert.Equal(new BigInteger(expected), result);
        }

        [Fact]
        public void NegativeInput_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Class1.CountPairs(-1));
        }

        [Fact]
        public void TooLargeInput_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Class1.CountPairs(16));
        }
    }
}