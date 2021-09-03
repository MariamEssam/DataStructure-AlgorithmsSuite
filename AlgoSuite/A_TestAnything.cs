using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{

    class TestAnything
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int[] dp = new int[nums.Length];
            dp[0] = 1;
            int maxans = 1;
            for(int i=1;i<nums.Length;i++)
            {
                int maxval = 0;
                for(int j=0;j<i;j++)
                {
                    if (nums[i] > nums[j])
                        maxval = Math.Max(maxval, dp[i]);
                }
                dp[i] = maxval + 1;
                maxans = Math.Max(dp[i], maxans);
            }
            return maxans;
        }
        public int LengthOfLIS_BruteForce(int[] nums)
        {
            return LengthofLISHelper(nums, int.MinValue, 0);

        }
        public int LengthofLISHelper(int[] nums,int prev,int currposition)
        {
            if (currposition == nums.Length)
                return 0;
            int taken = 0;
            if (nums[currposition] > prev)
                taken = 1 + LengthofLISHelper(nums, nums[currposition], currposition + 1);
            int nottaken = LengthofLISHelper(nums, prev, currposition + 1);
            return Math.Max(nottaken, taken);
        }

    }
}
