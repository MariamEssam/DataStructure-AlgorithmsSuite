using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SearchInRotatedArray
    {
       public int BinarySearch(int[] nums,int start,int end,int target)
        {
            while(start<=end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                    return mid;
                if (nums[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return -1;
        }
       public int findRotateIndex(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            if (nums[left] <= nums[right]) return 0;
            while(left<=right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1])
                    return mid + 1;
                if (nums[mid] < nums[left])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return 0;
        }
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            int pivot = findRotateIndex(nums);
            if (target == nums[pivot])
                return pivot;
            if (target >= nums[0])
                return BinarySearch(nums,0, pivot - 1, target);
            return BinarySearch(nums, pivot, nums.Length - 1, target);
        }
        /// <summary>
        /// One pass
        /// </summary>
        //public int Search(int[] nums, int target)
        //{
        //    int start = 0, end = nums.Length - 1;
        //    while(start<=end)
        //    {
        //        int mid = start + (end - start) / 2;
        //        if (nums[mid] == target) return mid;
        //        if(nums[mid]>=nums[start])
        //        {
        //            if (target > nums[mid]) end = mid - 1;
        //            else start = mid + 1;
        //        }
        //    }
        //}
    }
}
