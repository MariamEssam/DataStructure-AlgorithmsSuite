using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/coin-change/
    /// <ID>1322</ID>
    /// </summary>
    class CoinChangeC
    {
        /// <summary>
        /// My solution and it's good
        /// </summary>
        public int CoinChange1(int[] coins, int amount)
        {
            if (amount == 0) return 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(0, 0);
            Array.Sort(coins);
            for (int i = coins.Length - 1; i >= 0; i--)
            {
                int val = coins[i];
                while (val <= amount)
                {
                    if (!dic.ContainsKey(val))
                    {
                        var keys = dic.Keys.ToList();
                        foreach (var k in keys)
                        {
                            if (k + val <= amount)
                            {
                                if (!dic.ContainsKey(k + val))
                                    dic.Add(k + val, (val / coins[i]) + dic[k]);
                            }
                        }
                        if (!dic.ContainsKey(val))
                            dic.Add(val, val / coins[i]);
                        else
                            dic[val] = Math.Min(val / coins[i], dic[val]);

                    }

                    val += coins[i];
                }
            }
            return dic.ContainsKey(amount) ? dic[amount] : -1;
        }
        int CoinChangeHelper(int[] coins,int amount,int[] count)
        {
            if (amount == 0) return 0;
            if (amount < 0) return -1;
            if (count[amount] != 0) return count[amount];
            int min = int.MaxValue;
            for(int i=0;i<coins.Length;i++)
            {
                int val = CoinChangeHelper(coins, amount - coins[i], count);
                if (val >= 0 && val < min)
                    min = val + 1;
            }
            count[amount] = min == int.MaxValue ? -1 : min;
            return count[amount];
        }
        /// <summary>
        /// Top-down solution
        /// </summary>
        public int CoinChange_TOP_DOWN(int[] coins, int amount)
        {
            int[] count = new int[amount + 1];
            CoinChangeHelper(coins, amount, count);
            return count[amount];
        }
    }
}
