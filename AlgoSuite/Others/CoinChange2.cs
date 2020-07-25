using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class CoinChange2
    {
        public int Change(int amount, int[] coins)
        {
            int[] dp= new int[amount+1];
            dp[0] = 1;
            for(int i=0;i<coins.Length;i++)
            {
                int num = coins[i];
                for (int x = num; x < amount + 1; ++x)
                {
                    dp[x] += dp[x - num];
                }
            }
            return dp[amount];
        }
    }
}
