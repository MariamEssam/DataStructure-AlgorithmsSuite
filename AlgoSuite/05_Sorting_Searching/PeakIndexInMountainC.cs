using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/peak-index-in-a-mountain-array/
    /// <ID>041</ID>
    /// </summary>
    class PeakIndexInMountainC
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            if (A.Length < 3) return 0;
            int ptr = 1;
            while (ptr < A.Length - 1)
            {
                if (A[ptr] > A[ptr - 1] && A[ptr] > A[ptr + 1]) return ptr;
                ptr++;
            }
            return 0;
        }
    }
}
