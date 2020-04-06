using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MaxGapC
    {
        public int maximumGap(List<int> A)
        {
            int[] LMin = new int[A.Count];
            int[] RMax = new int[A.Count];
            LMin[0] = A[0];
            for (int i=1;i<A.Count;i++)
            {
                LMin[i]=(Math.Min(A[i], LMin[i - 1]));
            }
            RMax[A.Count - 1] = A[A.Count - 1];
            for(int j=A.Count-2;j>=0;j--)
            {
                RMax[j] = Math.Max(RMax[j + 1], A[j]);
            }
            int ptr0 = 0, ptr1 = 0;
            int maxdiff = 0;
            while(ptr0<A.Count&&ptr1<A.Count)
            {
                if (LMin[ptr0] <= RMax[ptr1])
                {
                    maxdiff = Math.Max(maxdiff, ptr1 - ptr0);
                    ptr1++;
                }
                else
                {
                    ptr0++;
                }
            }
            return maxdiff;
        }
        
    }
}
