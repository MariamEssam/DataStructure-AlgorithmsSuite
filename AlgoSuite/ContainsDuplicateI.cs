using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate/
    /// <ID>1217</ID>
    /// </summary>
    class ContainsDuplicateI
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            int i = 0;
            while(i<nums.Length)
            {
                if (set.Contains(nums[i])) return true;
                set.Add(nums[i]);
                i++;
            }
            return false;
        }
    }
}
