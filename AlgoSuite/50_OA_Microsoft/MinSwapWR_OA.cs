using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MinSwapWR_OA
    {
        public int MinSwap(string str)
        {
            List<int> R_list = new List<int>();
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == 'R')
                    R_list.Add(i);
            }
            int mid = R_list.Count / 2;
            int Min_Swap = 0;
            for(int i=0;i<R_list.Count;i++)
            {
                Min_Swap += (Math.Abs(R_list[mid] - R_list[i]) - Math.Abs(mid - i));
            }
            return Min_Swap;
        }
    }
}
