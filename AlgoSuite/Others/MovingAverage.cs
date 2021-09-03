using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/moving-average-from-data-stream/
    /// <ID>1346</ID>
    /// </summary>
    class MovingAverage
    {
        int index = -1;
        int[] arr;
        int Sum = 0;
        int Size;
        double count;
        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {
            arr = new int[size];
            Size = size;
            count = 0;
        }
        public double Next(int val)
        {
            index++;
            count = Math.Min(Size, count + 1);
            index = index % Size;
            Sum -= arr[index];
            Sum += val;
            arr[index] = val;
            return Sum / count;
        }
    }
}
