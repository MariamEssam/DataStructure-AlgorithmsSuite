using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class CandyDist
    {
        public int Candy(int[] ratings)
        {
            int count = 0;
            int[] candyarr = new int[ratings.Length];
            for (int i = 0; i < ratings.Length; i++)
                candyarr[i] = 1;
            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    candyarr[i] = candyarr[i - 1] + 1;
            }
            count += candyarr[ratings.Length - 1];
            for (int i = ratings.Length - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                    candyarr[i] = Math.Max(candyarr[i + 1] + 1,candyarr[i]);
                count += candyarr[i];
            }
            
            return count;
        }
    }
}
