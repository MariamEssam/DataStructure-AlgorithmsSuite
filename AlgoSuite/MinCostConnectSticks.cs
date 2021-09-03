using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-to-connect-sticks/solution/
    /// <ID>2167</ID>
    /// </summary>
    class CompareInt : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
    class MinCostConnectSticks
    {
        public int ConnectSticks(int[] sticks)
        {
            IComparer<int> cmp = new CompareInt();
            MinHeap<int> heap = new MinHeap<int>(cmp);
            int cost = 0;
            for (int i = 0; i < sticks.Length; i++)
                heap.add(sticks[i]);
            while(heap.size>1)
            {
                int val1 = heap.poll();
                int val2 = heap.poll();
                int sum = val1 + val2;
                heap.add(sum);
                cost += sum;
            }
            return cost;
        }
    }
}
