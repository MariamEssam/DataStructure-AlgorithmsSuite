﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class DistributeCandies2
    {
        public int DistributeCandies(int[] candies)
        {
            HashSet<int> dic = new HashSet<int>();
            for(int i=0;i<candies.Length;i++)
            {
                if (!dic.Contains(candies[i])) dic.Add(candies[i]);
            }
            return dic.Count > (candies.Length / 2) ? candies.Length / 2 : dic.Count;
        }
    }
}
