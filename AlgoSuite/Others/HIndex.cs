using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class HIndexC
    {
        public int HIndex(int[] citations)
        {
            if (citations.Length == 0) return 0;
            int hindex = 0;
            Array.Sort(citations);
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[citations.Length - 1 - i] > i)
                    hindex = i + 1;
            }
            return hindex;
        }
    }
}
