using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class _3SumCloset
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int closetsum = nums[0] + nums[1] + nums[2];
            int sum = closetsum;
            for(int i=3;i<nums.Length;i++)
            {
                sum -= nums[i - 3];
                sum += nums[i];
                closetsum = Math.Abs(sum - target) < Math.Abs(closetsum - target) ? sum : closetsum;
            }
            return closetsum;
        }
    }
}
