using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/longest-increasing-subsequence/
    /// </summary>
    class LongestIncreasingSubseq
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int[] LincrSeq = new int[nums.Length];
            int max = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                LincrSeq[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j] && LincrSeq[i] < LincrSeq[j] + 1)
                    {
                        LincrSeq[i] = LincrSeq[j] + 1;
                        max = Math.Max(max, LincrSeq[i]);
                    }
                }

            }
            return max;
        }
    }
}
