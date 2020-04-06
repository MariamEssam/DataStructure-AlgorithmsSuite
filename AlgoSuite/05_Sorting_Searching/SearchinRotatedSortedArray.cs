using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SearchinRotatedSortedArray
    {
        int findMin(int[] nums)
        {
            int start = 0, end = nums.Length - 1;
            if (nums[0] < nums[nums.Length - 1])
                return 0;
            while(start<=end)
            {
                int mid = (start + end) / 2;

                if (nums[mid + 1] < nums[mid]) return mid + 1;
                if (nums[mid] < nums[mid - 1]) return mid;
                if (nums[0] < nums[mid]) start = mid + 1;
                else end = mid - 1; 
            }
            return -1;
        }
        int BS(int[] nums,int start,int end,int target)
        {
            if(start<=end)
            {
                int mid = (start + end) / 2;
                if(nums[mid]==target)
                {
                    return mid;
                }
                else if(nums[mid]>target)
                {
                    return BS(nums, start, mid - 1, target);
                }
                else
                {
                    return BS(nums, mid + 1, end, target);
                }
            }
            return -1;
        }
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
                return -1;
            if (nums.Length == 1)
                if (nums[0] == target) return 0;
                else return -1;
            int pivot = findMin(nums);
            if (nums[pivot] == target)
                return pivot;
            if (pivot == 0)
                return BS(nums, 0, nums.Length - 1, target);
           if(nums[0]<=target&&target<=nums[pivot-1])
            {
                return BS(nums, 0, pivot-1,target); 
            } 
           else
            {
                return BS(nums, pivot + 1, nums.Length - 1,target);
            }
          }
    }
}