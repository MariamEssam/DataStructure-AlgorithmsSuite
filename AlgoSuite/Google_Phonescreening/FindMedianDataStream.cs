using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/find-median-from-data-stream/
    /// <ID>1295</ID>
    /// </summary>
    class MedianFinder
    {
        List<int> stream;
        /** initialize your data structure here. */
        public MedianFinder()
        {
            stream = new List<int>();
        }

        public void AddNum(int num)
        {
            int l = 0, R = stream.Count - 1;
            while(l<=R)
            {
                int mid = (l + R) / 2;
                if(stream[mid]<num)
                {
                    l = mid + 1;
                }
                else if(stream[mid]>num)
                {
                    R = mid - 1;
                }
                else
                {
                    l = mid;
                    break;
                }
            }
            stream.Insert(l, num);
        }

        public double FindMedian()
        {
            if(stream.Count%2==0)
            {
               int sum= stream[stream.Count / 2] + stream[(stream.Count / 2) - 1];
                return sum / 2.0;
            }
            else
            {
                return stream[stream.Count / 2];
            }
        }

    }
}
