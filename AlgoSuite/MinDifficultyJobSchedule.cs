using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MinDifficultyJobSchedule
    {
        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            int n = jobDifficulty.Length, inf = int.MaxValue, maxd;
            int[] dp = new int[n + 1];
            if (n < d) return -1;
            for (int i = n - 1; i >= 0; i--)
                dp[i] = Math.Max(dp[i + 1], jobDifficulty[i]);
            for(int k=2;k<=d;k++)
            {
                for(int i=0;i<=n-k;i++)
                {
                    maxd = 0;
                    dp[i] = inf;
                    for(int j=i;j<=n-k;j++)
                    {
                        maxd = Math.Max(maxd, jobDifficulty[j]);
                        dp[i] = Math.Min(dp[i], maxd + dp[j + 1]);
                    }
                }
            }
            return dp[0];

        }
    }
}
