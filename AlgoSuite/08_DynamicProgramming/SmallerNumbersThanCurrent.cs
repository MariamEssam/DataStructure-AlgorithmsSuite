using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
    /// <ID>090</ID>
    /// </summary>
    class SmallerNumbersThanCurrentC
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] count = new int[101];
            for (int i = 0; i < nums.Length; i++)
                count[nums[i]]++;
            for (int i = 1; i < count.Length; i++)
                count[i] += count[i - 1];
            for (int i = 0; i < nums.Length; i++)
                if(nums[i]!=0)
                nums[i]=count[nums[i] - 1];
            return nums;
        }

        public int[] SmallerNumbersThanCurrent2(int[] nums)
        {
            int[] res = new int[nums.Length];
            Array.Copy(nums, res, nums.Length);
            Array.Sort(nums);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int count = 0;
            for (int i=0;i<nums.Length;i++)
            {
                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], count);
                count++;
            }
            for (int i = 0; i < res.Length; i++)
            {
                res[i]=dic[res[i]];
            }
            return res;
        }
    }
}
