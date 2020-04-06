using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FirstLastPos
    {
        int findIndex(int[] nums, int target, bool lowerbound)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid = 0;
            int index = -1;
            while (low <= high)
            {
                mid = (low + high) / 2;
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
                    if (lowerbound)
                    {
                        if (mid - 1 < 0 || nums[mid - 1] < nums[mid])
                            return mid;
                        high--;
                    }
                    else
                    {
                        if (mid + 1 >= nums.Length || nums[mid + 1] > nums[mid])
                            return mid;
                        low++;
                    }
                }
            }
            return index;
        }
        public int[] SearchRange(int[] nums, int target)
        {
            int[] indices = new int[2];
            indices[0] = findIndex(nums, target, true);
            indices[1] = findIndex(nums, target, false);
            return indices;
        }
    }
}
