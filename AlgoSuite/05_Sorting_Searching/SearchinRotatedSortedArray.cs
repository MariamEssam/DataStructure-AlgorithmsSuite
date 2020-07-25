using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    /// <ID>035</ID>
    /// </summary>
    class SearchinRotatedSortedArray
    {
        public int FindMin2(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            while (low < high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] < nums[high])
                    high = mid;
                else 
                    low = mid + 1;
            }
            return nums[low];
        }
        public int FindMin(int[] nums)
        {

            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (mid >= 1 && nums[mid] < nums[mid - 1]) return nums[mid];
                if (mid < nums.Length - 1 && nums[mid] > nums[mid + 1]) return nums[mid + 1];
                if (nums[0] > nums[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

            }
            return Math.Min(nums[0], nums[nums.Length - 1]);
        }
    }
}