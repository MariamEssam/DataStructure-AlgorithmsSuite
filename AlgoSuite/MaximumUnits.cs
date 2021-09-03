using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/793606/amazon-oa-2020-maximum-units
    /// <ID>5009</ID>
    /// </summary>
    class MaximumUnits
    {
        public  long getMaxUnits(List<long> boxes, List<long> unitsPerBox, long truckSize)
        {
            SortedDictionary<long, MinHeap<long>> dic = new SortedDictionary<long, MinHeap<long>>();
            for(int i=0;i<unitsPerBox.Count;i++)
            {
                IComparer<long> cc = new CompareLong();
                if (!dic.ContainsKey(unitsPerBox[i])) dic.Add(unitsPerBox[i], new AlgoSuite.MinHeap<long>(cc));
                dic[unitsPerBox[i]].add(boxes[i]);
            }
            long MaxUnits = 0 , total = 0;
            foreach(var item in dic.Reverse())
            {
                while(item.Value.size!=0&&item.Value.Peek()<=(truckSize-total))
                {
                    MaxUnits += (item.Key*item.Value.Peek());
                    total += item.Value.poll();
                    if (total == truckSize)
                        return MaxUnits;
                }
            }

            return MaxUnits;

        }
    }
}
