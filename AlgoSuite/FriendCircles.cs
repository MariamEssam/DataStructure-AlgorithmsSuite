using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FriendCircles
    {
        void ExploreCycle(bool[] visited,int[][] graph,int index)
        {
            if (visited[index]) return;
            visited[index] = true;
            for(int i=0;i<graph.Length;i++)
            {
                if(i!=index&&graph[index][i]==1)
                {
                    ExploreCycle(visited, graph, i);
                }
            }
        }
        public int FindCircleNum(int[][] M)
        {
            bool[] visited = new bool[M.Length];
            int count = 0;
            for(int i=0;i<M.Length;i++)
            {
                if(!visited[i])
                {
                    count++;
                    ExploreCycle(visited, M, i);
                }
            }
            return count;
        }
    }
}
