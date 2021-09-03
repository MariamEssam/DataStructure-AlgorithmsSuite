using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
    /// <ID>1122</ID>
    /// </summary>
    class BestTimetoBuyandSell
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for(int i=1;i<prices.Length;i++)
            {
                if (prices[i] > prices[i - 1])
                    maxProfit += prices[i] - prices[i - 1];
            }
            return maxProfit;
        }
    }
}
