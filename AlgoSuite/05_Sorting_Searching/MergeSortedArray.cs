using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/
    /// <ID>1088</ID>
    /// </summary>
    class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int ptr = nums1.Length - 1;
            int ptr1 = m - 1;
            int ptr2 = n - 1;
            while(ptr>=0)
            {
                if(ptr2<0||(ptr1>=0&&nums1[ptr1]>nums2[ptr2]))
                {
                    nums1[ptr--] = nums1[ptr1--];
                }
                else
                {
                    nums1[ptr--] = nums2[ptr2--];
                }
            }
        }
    }
}
