using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// <ID>038</ID>
    /// </summary>
    class MedianTwoSortedArray
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int medianloc = (int)Math.Ceiling((nums1.Length + nums2.Length) / 2.0);
            bool IsEven = ((nums1.Length + nums2.Length) % 2.0)==0?true:false;
            int ptr1 = 0, ptr2 = 0;
            int count = 0;
            double median = 0;
            while(true)
            {
                int val = 0;
                if (ptr2>=nums2.Length||(ptr1<nums1.Length &&nums1[ptr1] < nums2[ptr2]))
                {

                    val = nums1[ptr1++]; 
                    
                }
                else
                {
                    val = nums2[ptr2++];
                }
                count++;
                if(medianloc==count)
                {
                    median += val;
                    if (IsEven)
                    {
                        medianloc++;
                        IsEven = false;
                    }
                    else
                        break;
                }
            }
            IsEven= ((nums1.Length + nums2.Length) % 2.0) == 0 ? true : false;
            if (IsEven)
                median = median / 2;
            return median;
        }
    }
}
