using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MaximumXORTwoArray
    {
        public int FindMaximumXOR(int[] nums)
        {
            int maxnum = nums[0];
            for (int i = 1; i < nums.Length; i++) maxnum = Math.Max(nums[i], maxnum);
            int L = 0;
            while (maxnum != 0) { L++; maxnum >>= 1; }
            int max_xor = 0, curr_xor;
            HashSet<int> set = new HashSet<int>();
            for(int i=L-1; i>=0;i--)
            {
                set.Clear();
                max_xor <<= 1;
                curr_xor = max_xor | 1;
                for(int j=0;j<nums.Length;j++)
                {
                    if (!set.Contains(nums[j] >> i)) set.Add(nums[j] >> i);
                }
                foreach(int p in set)
                {
                    if(set.Contains(curr_xor^p))
                    {
                        max_xor = curr_xor;
                        break;
                    }
                }
            }
            return max_xor;
        }
    }
}
