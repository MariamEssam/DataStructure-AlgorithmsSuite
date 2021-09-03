using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PartitionLabelsC
    {
        public IList<int> PartitionLabels(string S)
        {
            IList<int> resut = new List<int>();
            int[] lastseen = new int[26];
            int lastIndex = -1, firstIndex = 0;
            for(int i=0;i<S.Length;i++)
            {
                lastseen[S[i] - 'a'] = i;
            }
           for(int i=0;i<S.Length;i++)
            {
                lastIndex = Math.Max(lastIndex, lastseen[S[i] - 'a']);
                if (i == lastIndex || i == S.Length - 1)
                {
                    resut.Add(lastIndex - firstIndex + 1);
                    firstIndex = lastIndex + 1;
                }
            }
            return resut;
        }
    }
}
