using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// <ID>1053</ID>
    /// </summary>
    class MaxSubArrayC
    {

        public int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue;
            int currSum = nums[0];
            for(int i=1;i<nums.Length;i++)
            {
                currSum = Math.Max(nums[i], nums[i] + currSum);
                maxSum = Math.Max(currSum, maxSum);
            }
            return maxSum;
         }
    }
}
