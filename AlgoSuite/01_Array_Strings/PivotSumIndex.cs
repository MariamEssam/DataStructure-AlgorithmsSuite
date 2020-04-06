using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PivotSumIndex
    {
        /// <summary>
        /// https://leetcode.com/problems/find-pivot-index/
        /// <ID>010</ID>
        /// </summary>
        public int PivotIndex(int[] nums)
        {
            int sumright = 0, sumleft=0;
            for (int i = 0; i < nums.Length; i++) sumright += nums[i];
            for(int i=0;i<nums.Length;i++)
            {
                sumright -= nums[i];
                if (sumright == sumleft) return i;
                sumleft += nums[i];
            }
            return -1;
        }
    }
}
