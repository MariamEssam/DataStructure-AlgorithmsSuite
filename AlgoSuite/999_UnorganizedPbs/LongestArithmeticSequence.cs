using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LongestArithmeticSequence
    {
        public int LongestArithSeqLength(int[] A)
        {
            int maxSubArray = 2;
            Dictionary<int, int>[] dic = new Dictionary<int, int>[A.Length];
            for(int i=0;i<A.Length;i++)
            {
                dic[i] = new Dictionary<int, int>();
                for(int j=0;j<i;j++)
                {
                    int d = A[i] - A[j];
                    int val = 1;
                    if (dic[j].ContainsKey(d)) val = dic[j][d];
                    if (!dic[i].ContainsKey(d))
                        dic[i].Add(d, val + 1);
                    else
                        dic[i][d] =Math.Max( val + 1,dic[i][d]);
                    maxSubArray=Math.Max(maxSubArray, val + 1);
                }

            }
            return maxSubArray;
        }
    }
}
