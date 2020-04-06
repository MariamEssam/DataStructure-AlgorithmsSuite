using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FindMinimuminRotatedSortedArray
    {
        int helper(int[] nums, int start, int end, int Min)
        {
            if (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] >= Min)
                {
                    return helper(nums, mid + 1, end, Min);
                }
                else if (nums[mid] < Min)
                {
                    Min = nums[mid];
                    return helper(nums, start, mid - 1, Min);
                }

            }
            return Min;
        }
        public int FindMin2(int[] nums)
        {
            if (nums.Length == 0)
                return -1;
            return helper(nums, 0, nums.Length - 1, nums[0]);
        }
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            if (nums[0] < nums[nums.Length - 1])
                return nums[0];
            int start = 0, end = nums.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] < nums[mid - 1]) return nums[mid];
                if (nums[mid] > nums[mid + 1]) return nums[mid + 1];
                if (nums[0] < nums[mid])
                    start = mid + 1;
                else if (nums[0] > nums[mid])
                    end = mid - 1;
            }
            return -1;
        }
    }
}
