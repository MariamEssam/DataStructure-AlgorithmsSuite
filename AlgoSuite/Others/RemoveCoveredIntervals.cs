using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    //class Sort2DArray : System.Collections.Generic.IComparer
    //{
    //    public int Compare(object x, object y)
    //    {
    //        int[] a = (int[])x;
    //        int[] b = (int[])y;
    //        if (a[0] > b[0])
    //            return 1;
    //        else if (a[0] < b[0])
    //            return -1;
    //        else
    //        {
    //            if (a[1] < b[1]) return 1;
    //            else return -1;
    //        }
    //    }
    //}
    //class RemoveCoveredIntervalsC
    //{
    //    public int RemoveCoveredIntervals(int[][] intervals)
    //    {
    //        HashSet<int> indices = new HashSet<int>();
    //        int ptr = 0;
    //        IComparer ss = new Sort2DArray();
    //        intervals = intervals.OrderBy(row => row[0],ss).ToArray();
    //        while(ptr<intervals.Length -1)
    //        {
    //            if (indices.Contains(ptr)) continue;
    //            for(int i=ptr+1;i<intervals.Length;i++)
    //            {
    //                if (intervals[ptr][1] < intervals[i][0]) break;
    //                if (intervals[ptr][1] > intervals[i][1])
    //                {
    //                    indices.Add(i);
    //                }
    //            }
    //        }
    //        return intervals.Length - indices.Count;
    //    }
    //}
}
