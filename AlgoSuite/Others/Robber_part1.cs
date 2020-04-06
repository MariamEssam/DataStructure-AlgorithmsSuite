using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// <tag>Dynamic programming</tag>
    /// <ID>198</ID>
    /// <code>000003</code>
    /// <Link>https://leetcode.com/problems/house-robber/</Link>
    /// </summary>
    class Robber_part1
    {
        public int Rob(int[] nums)
        {
            int a = 0, b = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if (i % 2 == 0)
                    a = Math.Max(a + nums[i], b);
                else
                    b = Math.Max(b + nums[i], a);
            }
            return Math.Max(a, b);
        }
    }
}
