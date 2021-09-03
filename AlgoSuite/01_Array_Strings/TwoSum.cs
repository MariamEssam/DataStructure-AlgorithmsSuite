using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// <ID>1001</ID>
    /// </summary>
    class TwoSumC
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            //We can do this in one loop. In the loop we look for the value and at
            //same time add what's already doesn't exisit.
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    int[] ans = new int[2];
                    ans[0] = dic[target - nums[i]];
                    ans[1] = i;
                    return ans;
                }
                else if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }
            return new int[2];
        }

    }
}
