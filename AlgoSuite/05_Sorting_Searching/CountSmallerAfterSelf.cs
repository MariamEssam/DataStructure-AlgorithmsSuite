using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class Pair
    {
        public int val;
        public int index;
        public Pair(int _val,int _index)
        {
            val = _val;
            index = _index;
        }
    }
    class CountSmallerAfterSelf
    {
        Pair[] Merge(Pair[] arr,int[] smaller)
        {
            if (arr.Length <= 1) return arr;
            int mid = arr.Length / 2;
            Pair[] L = new Pair[mid];
            Pair[] R = new Pair[arr.Length - mid];

            Array.Copy(arr, 0, L, 0, mid);
            Array.Copy(arr, mid, R, 0,arr.Length-mid);

            L = Merge(L, smaller);
            R = Merge(R, smaller);
            for (int i = 0, j = 0; i < L.Length||j < R.Length;)
            {
                if(j==R.Length||(i<L.Length&&L[i].val<=R[j].val))
                {
                    arr[i + j] = L[i];
                    smaller[L[i].index] += j;
                    i++;
                }
                else
                {
                    arr[i + j] = R[j];
                    j++;
                }
            }
            return arr;
        }

        public IList<int> CountSmaller(int[] nums)
        {
            IList<int> res = new List<int>();
            if (nums == null || nums.Length == 0) return res;
            int[] smaller = new int[nums.Length];
            Pair[] pairs = new Pair[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                pairs[i] = new Pair(nums[i], i);
            }
            Merge(pairs, smaller);
            return smaller;
        }
    }
}
