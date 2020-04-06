using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class RemoveDuplicatesfromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length==0)
                return 0;
            int ptr = -1;
            for(int i=0;i<nums.Length;i++)
            {
                if(ptr==-1||nums[ptr]!=nums[i])
                {
                    nums[++ptr] = nums[i];
                }
            }
            return ptr + 1;
        }
    }
}
