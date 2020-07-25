using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FindTownJudge
    {
        public int FindJudge(int N, int[][] trust)
        {
            if (trust.Length < N - 1)
            {
                return -1;
            }

            int[] indegrees = new int[N + 1];
            int[] outdegrees = new int[N + 1];

            foreach (var relation in trust)
            {
                outdegrees[relation[0]]++;
                indegrees[relation[1]]++;
            }

            for (int i = 1; i <= N; i++)
            {
                if (indegrees[i] == N - 1 && outdegrees[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
