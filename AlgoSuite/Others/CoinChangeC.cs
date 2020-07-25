using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
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
        //public int coinChange(int[] coins, int amount)
        //{
        //}
        //private int coinChange(int[] coins, int rem, int[] count)
        //{
        //}
    }
}
