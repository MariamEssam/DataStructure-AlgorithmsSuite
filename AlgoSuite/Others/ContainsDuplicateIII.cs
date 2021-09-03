using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ContainsDuplicateIII
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            for(int i=0;i<nums.Length-k;i++)
            {
                int max = i + k + 1 < nums.Length ? i + k + 1 : nums.Length;
                for(int j=i+1;j<i+k;j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) <= t)
                        return true;
                }
            }
            return false;
        }
    }
}
