using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-three-sorted-arrays/
    /// <ID>077</ID>
    /// </summary>
    class IntersectionThreeSortedArrays
    {
        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            IList<int> res = new List<int>();
            int ptr1 = 0, ptr2 = 0, ptr3 = 0;
            while(ptr1<arr1.Length&&ptr2<arr2.Length&&ptr3<arr3.Length)
            {
                if(arr1[ptr1]==arr2[ptr2]&&arr2[ptr2]==arr3[ptr3])
                {
                    res.Add(arr1[ptr1]);
                    ptr1++;ptr2++;ptr3++;
                }
                else
                {
                    if (arr1[ptr1] <= arr2[ptr2] && arr1[ptr1] <= arr3[ptr3])
                    {
                        ptr1++;
                    }
                    else if (arr2[ptr2] <= arr1[ptr1] && arr2[ptr2] <= arr3[ptr3])
                    {
                        ptr2++;
                    }
                    else
                        ptr3++;
                }
            }
            return res;
        }
    }
}
