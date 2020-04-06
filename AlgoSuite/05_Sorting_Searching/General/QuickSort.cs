using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class QuickSort
    {
        void swap(int[] arr, int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        int Partion(int[] arr,int start,int end)
        {
            int ptr = start - 1;
            Random rand = new Random();
            int pivotIndex = rand.Next(start, end + 1);
            swap(arr, pivotIndex, end);
            pivotIndex = end;
            int pivot = arr[pivotIndex];
            for(int i=start;i<end;i++)
            {
                if(arr[i]<pivot)
                {
                    ptr++;
                    swap(arr, ptr, i);
                }
            }

            swap(arr, pivotIndex, ++ptr);
            return ptr;
        }
        void helper(int[] arr,int start,int end)
        {
            if(start<end)
            {
                int ptr = Partion(arr, start, end);
                helper(arr, start, ptr-1);
                helper(arr, ptr + 1, end);
            }
        }
        public void Sort(int[] arr)
        {
            helper(arr, 0, arr.Length - 1);
        }
    }
}
