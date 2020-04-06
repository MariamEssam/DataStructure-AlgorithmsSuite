using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ParticleVelocity
    {
        public int NumberOfArithmeticSlices(int[] A)
        {
            if (A.Length < 3) return 0;
            int[] dp = new int[A.Length];
            int sum = 0;
            for (int i = 2; i < A.Length; i++)
            {
                if((A[i-1]-A[i])==(A[i-2]-A[i-1]))
                {
                    dp[i] = 1 + dp[i - 1];
                    sum += dp[i];
                }
            }
            return sum;
        }
    }
}
