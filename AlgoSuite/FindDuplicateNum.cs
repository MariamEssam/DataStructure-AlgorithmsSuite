using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FindDuplicateNum
    {
        public int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for(int i=1;i<nums.Length;i++)
            {
                if (nums[i - 1] == nums[i])
                    return nums[i];
            }
            return -1;
        }
    }
}
