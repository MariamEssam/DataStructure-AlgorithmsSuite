using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MajorityElementC
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0; i<nums.Length;i++)
            {
                if (!dic.ContainsKey(nums[i])) dic.Add(nums[i], 0);
                if (++dic[nums[i]] > nums.Length / 2) return nums[i];
            }
            return 0;
        }
    }
}
