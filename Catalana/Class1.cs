using System.Numerics;

namespace Catalana
{
    public class Class1
    {
        public static BigInteger CountPairs(int pairs)
        {
            if (pairs < 0 || pairs > 15)
                throw new ArgumentOutOfRangeException("pairs will be need between 0 and 15");

            return Coefficient(2 * pairs, pairs) / (pairs + 1);
        }

        private static BigInteger Coefficient(int n, int k)
        {
            if (k > n) return 0;
            BigInteger result = 1;
            for (int i = 1; i <= k; i++)
            { 
                result *= n - (k - i);
                result /= i;
            }
            return result;
        }
    }
}
