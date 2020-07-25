using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/single-element-in-a-sorted-array/
    /// <ID>067</ID>
    /// </summary>
    class SingleElementSortedArray
    {
        public int SingleNonDuplicate(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            while(low<high)
            {
                int mid = low + (high - low) / 2;
                int offset = mid % 2 == 0 ? 1 : -1;
                
                    if(mid+offset<nums.Length&&mid+offset>=0&&nums[mid]==nums[mid+offset])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid;
                    }
                
                
            }
            return nums[low];
        }
    }
}
