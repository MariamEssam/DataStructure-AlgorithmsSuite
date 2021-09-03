using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SingleNumberIII
    {
        public int[] SingleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for(int i=0;i<nums.Length;i++)
            {
                if (set.Contains(nums[i])) set.Remove(nums[i]);
                else set.Add(nums[i]);
            }
            return set.ToArray();
        }
    }
}
