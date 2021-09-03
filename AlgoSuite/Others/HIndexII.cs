using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class HIndexII
    {
        public int HIndex(int[] citations)
        {
            if (citations.Length == 0) return 0;
            int l = 0, h = citations.Length;
            while (l < h)
            {
                int mid = (l + h) / 2;
                if (citations[citations.Length - 1 - mid] > mid)
                {
                    l = mid + 1;
                }
                else
                    h = mid;
            }
            return l;
        }
    }
}
