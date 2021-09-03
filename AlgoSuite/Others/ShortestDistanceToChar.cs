using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ShortestDistanceToChar
    {
        public int[] ShortestToChar(string S, char C)
        {
            int prev = int.MinValue/2;
            int[] arr = new int[S.Length];
            for(int i=0;i<S.Length;i++)
            {
                if (C == S[i]) prev = i;
                arr[i] = i - prev;
            }
            prev = int.MaxValue;
            for(int i=S.Length-1;i>=0;i--)
            {
                if (C == S[i]) prev = i;
                arr[i] = Math.Min(prev-i,arr[i]);

            }
            return arr;
        }
    }
}
