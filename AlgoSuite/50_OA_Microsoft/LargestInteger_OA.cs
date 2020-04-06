using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LargestInteger_OA
    {
        public int LargestInt(int[] arr)
        {
            Array.Sort(arr);
            int length = arr.Length;
            int ptr = 0;
            int i = length - 1;
            while((i>=0)&&(arr[i]>0))
            {
                
                while ((ptr<=length-i)&&(arr[i]+arr[ptr]<=0))
                {
                    if ((arr[i] + arr[ptr]) == 0) return arr[i];
                    ptr++;
                }
                i--;
            }
            return 0;
        }
    }
}
