using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SortedInsertPos
    {
        public int SearchInsert(int[] nums, int target)
        {
            int low = 0;int high = nums.Length - 1;
            while(low<=high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return low - 1;
        }
    }
}
