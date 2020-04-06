using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LengthofLongestSubseq
    {/// <summary>
     /// https://www.geeksforgeeks.org/longest-bitonic-subsequence-dp-15/
     /// https://www.interviewbit.com/problems/length-of-longest-subsequence/
     /// </summary>
     /// <param name="A"></param>
     /// <returns></returns>
        public int longestSubsequenceLength(List<int> A)
        {
            int[] LincrSeq = new int[A.Count];
            int[] LdecrSeq = new int[A.Count];
            int maxSubseq = 0;
            LincrSeq[0] = 1;
            LdecrSeq[A.Count - 1] = 1;
            for(int i=1;i<A.Count;i++)
            {
                LincrSeq[i] = 1;
                for(int j=0;j<i;j++)
                {
                    if (A[i] > A[j] && LincrSeq[i] < LincrSeq[j] + 1)
                        LincrSeq[i] = LincrSeq[j] + 1;
                }
               
            }
            for (int i = A.Count-2; i>=0; i--)
            {
                LdecrSeq[i] = 1;
                for (int j = A.Count-1; j > i; j--)
                {
                    if (A[i] > A[j] && LdecrSeq[i] < LdecrSeq[j] + 1)
                        LdecrSeq[i] = LdecrSeq[j] + 1;
                }
                
            }
            for(int i=0;i<A.Count;i++)
            {
                maxSubseq = Math.Max(maxSubseq, LincrSeq[i] + LdecrSeq[i] - 1);
            }
            return maxSubseq;
        }
    }
}
