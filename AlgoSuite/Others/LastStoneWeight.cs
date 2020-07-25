using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LastStoneWeightC
    {
        void Insertion(List<int> arr,int val)
        {
            int low = 0, high = arr.Count-1;
            while(low<high)
            {
                int mid = (low + high) / 2;
                if (val >= arr[mid])
                    low = mid;
                else
                    high = mid - 1;
            }
            arr.Insert(low, val);
        }
        public int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 0)
                return 0;
            if (stones.Length == 1)
                return stones[0];
           
            Array.Sort(stones);
            List<int> stones_lst = new List<int>();
            for (int i = 0; i < stones.Length; i++)
                stones_lst.Add(stones[i]);
            while (stones_lst.Count>1)
            {
                int val = 0;
                val= stones_lst[stones_lst.Count - 1] -stones_lst[stones_lst.Count - 2];
                stones_lst.RemoveAt(stones_lst.Count - 1);
                stones_lst.RemoveAt(stones_lst.Count - 1);
                if (val != 0) Insertion(stones_lst, val);
            }
            return stones_lst.Count==0?0:stones_lst[0];
        }
    }
}
