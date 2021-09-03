using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/merge-intervals/
    /// <ID>1056</ID>
    /// </summary>
    class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            List<int[]> mergedList = new List<int[]>();
            int[] start = new int[intervals.Length];
            int[] end = new int[intervals.Length];
            for(int i=0;i<intervals.Length;i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];

            }
            Array.Sort(start);
            Array.Sort(end);
            int ptr1 = 0;
            int ptr2 = 0;
            while(ptr1<intervals.Length)
            {
                mergedList.Add(new int[] { start[ptr1], end[ptr2] });
                
                while(ptr1+1 < intervals.Length&&start[ptr1+1]<=end[ptr2])
                {
                    ptr1++;
                    ptr2++;
                }
                mergedList[mergedList.Count - 1][1] = end[ptr2];
                ptr1++;
                ptr2++;
            }
            return mergedList.ToArray();
        }
    }
}
