using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class InsertIntervals
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)

        {
            List<int[]> mergedList = new List<int[]>();
            int size = intervals.Length + 1;
            int[] start = new int[size];
            int[] end = new int[size];
            for (int i = 0; i < intervals.Length; i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];

            }
            start[size - 1] = newInterval[0];
            end[size - 1] = newInterval[1];

            Array.Sort(start);
            Array.Sort(end);
            int ptr1 = 0;
            int ptr2 = 0;
            while (ptr1 < size)
            {
                mergedList.Add(new int[] { start[ptr1], end[ptr2] });

                while (ptr1 + 1 < size && start[ptr1 + 1] <= end[ptr2])
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
