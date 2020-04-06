using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SingleNumberC
    {
        public int SingleNumber(int[] nums)
        {
            int val = 0;
            for(int i=0;i<nums.Length;i++)
            {
                val ^= nums[i];
            }
            return val;
        }
    }
}
