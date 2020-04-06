using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class CountingInversions
    {
        int Merge(int[] arr, int start, int mid, int end)
        {
            int count = 0;
            int[] temp = new int[end - start + 1];
            int ptr1 = start, ptr2 = mid + 1;
            int k = 0;
            while (ptr1 <= mid || ptr2 <= end)
            {
                if (ptr2 > end||(ptr1<=mid&&arr[ptr1]<=arr[ptr2]))
                {
                    temp[k++] = arr[ptr1++];
                }
                else
                {
                    
                    temp[k++] = arr[ptr2++];
                    count += (mid - ptr1+1);
                }
            }
            k = 0;
            for(int i=start;i<=end;i++)
            {
                arr[i] = temp[k++];
            }
            return count;
        }
        int MergeHelper(int[] arr, int start,int end)
        {
            int count = 0;
            if(start<end)
            {
                int mid = (start + end) / 2;
                count += MergeHelper(arr, start, mid);
                count += MergeHelper(arr, mid+1,end);
                count += Merge(arr, start, mid, end);

            }
            return count;
        }
        public int InversionsCount(int[] arr)
        {
            return MergeHelper(arr, 0, arr.Length - 1);
        }
    }
}
