using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/subarray-sum-equals-k/
    /// <ID>010</ID>
    /// </summary>
    class SubArraySum
    {
        public int SubarraySum_CumilitiveSumWithSpace(int[] nums, int k)
        {
            int count = 0;
            int[] sum = new int[nums.Length + 1];
            sum[0] = 0;
            for (int i = 1; i < sum.Length; i++)
            {
                sum[i] = sum[i - 1] + nums[i];
            }
            for (int start = 0; start < sum.Length; start++)
            {
                for (int end = start + 1; end < sum.Length; end++)
                    if (sum[end] - sum[start] == k) count++;

            }
            return count;
        }
        public int SubarraySum_CumiltiveWithoutSpace(int[] nums, int k)
        {
            int count = 0;
            int accumsum = 0;
            for(int end=0;end<nums.Length;end++)
            {
                accumsum += nums[end];
                int sum = accumsum;
                for(int start=0;start<=end;start++)
                {
                    if (sum == k) count++;
                    sum = sum - nums[start];
                }
            }
            return count;
        }
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, 1);
            int count = 0, sum = 0;
            for(int i=0;i<nums.Length;i++)
            {
                sum += nums[i];
                if (map.ContainsKey(sum - k)) count += map[sum - k];
                if (map.ContainsKey(sum)) map[sum]++;
                else map.Add(sum, 1); 
            }
            return count;
        }
        }
}
