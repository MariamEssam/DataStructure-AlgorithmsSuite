using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class UncrossedLines
    {
       public int MaxUncrossedLines(int[] A, int[] B)
        {
            int[][] dp = new int[A.Length + 1][];
            for(int i=0;i<A.Length+1;i++)
            {
                dp[i] = new int[B.Length + 1];
            }
            for(int i=1;i<=A.Length;i++)
            {
                for(int j=1;j<=B.Length;j++)
                {
                    if (A[i - 1] == B[j - 1])
                    {
                        dp[i][j] = 1 + dp[i - 1][j - 1];
                    }
                    else
                        dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]);
                }
            }
            return dp[A.Length][B.Length];
        }
    }
}
