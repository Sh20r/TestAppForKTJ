using Catalana;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Test
    {
        [Fact]
        public void TestPerformance()
        {
            var sw = Stopwatch.StartNew();

            for (int i = 0; i <= 15; i++)
            {
                _ = Class1.CountPairs(i);
            }

            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 100, $"Too slow: {sw.ElapsedMilliseconds}ms");
        }
    }
}
