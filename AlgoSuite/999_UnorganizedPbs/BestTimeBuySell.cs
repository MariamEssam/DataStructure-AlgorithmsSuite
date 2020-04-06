using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BestTimeBuySell
    {
        public int MaxProfit(int[] prices)
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
