using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/372434
    /// <ID>5004</ID>
    /// </summary>
    class UniquePairs
    {
        public int getUniquePairs2(int[] nums, int target)
        {
            HashSet<int> set = new HashSet<int>();
            bool SameVal = false;
            //set.Add(nums[0]);
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    if (SameVal == false && 2 * nums[i] == target)
                    {
                        count++;
                        SameVal = true;
                    }
                    continue;
                } 
                if (set.Contains(target - nums[i])) count++;
                set.Add(nums[i]);
            }
            return count;
        }
        public  int getUniquePairs(int[] nums, int target)
        {
            HashSet<int> set = new HashSet<int>();
            HashSet<int> seen = new HashSet<int>();
            int count = 0;
            foreach (int num in nums)
            {
                if (set.Contains(target - num) && !seen.Contains(num))
                {
                    count++;
                    seen.Add(target - num);
                    seen.Add(num);
                }
                else if (!set.Contains(num))
                {
                    set.Add(num);
                }

            }

            return count;
        }
    }
}
