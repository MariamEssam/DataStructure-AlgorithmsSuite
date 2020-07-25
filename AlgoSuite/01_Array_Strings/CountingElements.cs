using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/counting-elements/
    /// <ID>057</ID>
    /// </summary>
    class CountingElements
    {
        public int CountElements(int[] arr)
        {
            int count = 0;
            HashSet<int> dic = new HashSet<int>();
            for(int i=0;i<arr.Length;i++)
            {
                if (!dic.Contains(arr[i])) dic.Add(arr[i]);
            }
            for(int i=0;i<arr.Length;i++)
            {
                if (dic.Contains(arr[i]+1)) count ++;
            }
            return count;
        }
    }
}
