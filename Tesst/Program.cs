using System.Diagnostics;
using Xunit;

namespace ParenthesesCounter.Tests
{
    public class PerformanceTests
    {
        [Fact]
        public void TestPerformance()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i <= 15; i++)
            {
                _ = Parentheses.CountWellFormedParenthesis(i);
            }

            stopwatch.Stop();
            Assert.True(stopwatch.ElapsedMilliseconds < 100, "Execution took too long");
        }
    }
}
