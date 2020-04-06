using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class Quickselect
    {
        void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        int Partion(int[] arr,int start,int end)
        {
            Random rand = new Random();
            int PivotIndex = rand.Next(start, end + 1);
            swap(arr, end, PivotIndex);
            PivotIndex = end;
            int ptr = start-1;
            for(int i=start;i<end;i++)
            {
                if(arr[i]<=arr[PivotIndex])
                {
                    ptr++;
                    swap(arr, ptr, i);
                }
            }
            swap(arr, ++ptr, PivotIndex);
            return ptr;
        }
        int helper(int[] arr,int start,int end,int k)
        {
            if(start<=end)
            {
                int ptr = Partion(arr, start, end);
                if(ptr==k-1)
                {
                    return arr[ptr];
                }
                else if(ptr>k-1)
                {
                    return helper(arr, start, ptr - 1, k);
                }
                else if(ptr<k-1)
                {
                    return helper(arr, ptr + 1, end, k - (ptr+1));
                }
            }
            return -1;
        }
        public int QuickSelectKth(int[] arr,int k)
        {
            return helper(arr, 0, arr.Length-1, k);
        }
    }
}
