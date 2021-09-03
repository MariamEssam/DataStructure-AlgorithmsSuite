using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// <ID>1121</ID>
    /// </summary>
    class BestTimeBuySell
    {
        public int MaxProfit(int[] prices)
        {
            int maxprofit = 0;
            if (prices.Length == 0) return 0;
            int minVal = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                maxprofit = Math.Max(prices[i] - minVal, maxprofit);
                minVal = Math.Min(minVal, prices[i]);
            }
            return maxprofit;
        }
        public int MaxProfit_Sol(int[] prices)
        {
            if (prices.Length <= 0) return 0;
            int minprice = int.MaxValue;
            int profit = 0;
            for(int i=0;i<prices.Length;i++)
            {
                if(minprice>prices[i])
                {
                    minprice = prices[i];
                }
                else if(prices[i]-minprice>profit)
                {
                    profit = prices[i] - minprice;
                }
            }
            return profit;
        }
     
    }
}
