using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BinarySearch
    {
        int searchhelper(int[] arr, int start,int end,int item)
        {
            int index = -1;
            if(start<=end)
            {
                int mid = (start + end) / 2;
                if (item == arr[mid])
                    return mid;
                if (item > arr[mid])
                    return searchhelper(arr, mid + 1, end, item);
                if (item < arr[mid])
                    return searchhelper(arr, start, mid - 1, item);
            }
            return index;
        }
        public int Search(int[] arr,int item)
        {
            return searchhelper(arr, 0, arr.Length-1, item);
        }
    }
}
