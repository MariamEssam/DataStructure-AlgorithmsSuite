using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/sort-an-array/
    /// <ID>048</ID>
    /// </summary>
    class Sorting
    {
        #region
        void Merge(int[] arr, int start, int mid, int end)
        {
            int[] temp = new int[end - start + 1];
            int ptr1 = start;
            int ptr2 = mid + 1;
            int k = 0;
            while (ptr1 <= mid || ptr2<=end)
            {
                if(ptr2>end||(ptr1<=mid&&arr[ptr1]<arr[ptr2]))
                {
                    temp[k++] = arr[ptr1++];
                }
                else
                {
                    temp[k++] = arr[ptr2++];
                }
            }
            k = 0;
            for(int i=start;i<=end;i++)
            {
                arr[i] = temp[k++];
            }

        }
        void MergeHelper(int[] arr,int start,int end)
        {
            if (start >= end)
                return;
            int mid = (start + end) / 2;
            Console.WriteLine("Start:" + start + " mid:" + mid + " end:" + end);
            MergeHelper(arr, start, mid);
            MergeHelper(arr, mid + 1, end);
            Merge(arr, start, mid, end);
        }
        public void MergeSort(int[] arr)
        {
            MergeHelper(arr, 0, arr.Length - 1);
        }
        #endregion
    }
}
