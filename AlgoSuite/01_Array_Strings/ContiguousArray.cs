using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/contiguous-array/
    /// <ID>052</ID>
    /// </summary>
    class ContiguousArray
    {
        public int findMaxLength(int[] nums)
        {
            int[] arr = new int[2 * nums.Length + 1];
            for(int k=0;k<arr.Length;k++) arr[k]= -2;
            arr[nums.Length] = -1;
            int maxlen = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count = count + (nums[i] == 0 ? -1 : 1);
                if (arr[count + nums.Length] >= -1)
                {
                    maxlen = Math.Max(maxlen, i - arr[count + nums.Length]);
                }
                else
                {
                    arr[count + nums.Length] = i;
                }

            }
            return maxlen;
        }
        public int FindMaxLength(int[] nums)
        {
            int max = 0,count=0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, -1);
            for(int i=0;i<nums.Length;i++)
            {
                count += (nums[i] == 1) ? 1 : -1;
                if (map.ContainsKey(count))
                {
                    max = Math.Max(max, i - map[count]);
                }
                else
                    map.Add(count, i);
            }

            return max;
        }
    }
}
