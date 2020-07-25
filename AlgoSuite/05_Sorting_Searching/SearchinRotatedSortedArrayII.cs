using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/
    /// <ID>036</ID>
    /// </summary>
    class SearchinRotatedSortedArrayII
    {
        public int FindMin(int[] nums)
        {

            int low = 0, high = nums.Length - 1;
            while (low < high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] < nums[high])
                    high = mid;
                else if (nums[mid] > nums[high])
                    low = mid + 1;
                else
                    high--;
            }
            return nums[low];
        }
    }
}
