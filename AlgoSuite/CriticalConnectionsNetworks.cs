using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/critical-connections-in-a-network/
    /// <ID>2192</ID>
    /// </summary>
    class CriticalConnectionsNetworks
    {
        public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
        {
            List<int>[] graph = new List<int>[n];
            for(int i=0;i<n;i++)
            {
                graph[i] = new List<int>();
            }
            for(int i=0;i<connections.Count;i++)
            {
                int v1 = connections[i][1],v0= connections[i][0];
                graph[v1].Add(v0);
                graph[v0].Add(v1);
            }
            bool[] visited = new bool[n];
            int[] timeAtNode = new int[n];
            int[] time = new int[1];
            IList<IList<int>> result = new List<IList<int>>();
            DFS(result,visited, timeAtNode, time, graph, 0, -1);
            return result;
        }
        void DFS(IList<IList<int>> result,bool[] visited,int[] timeAtNode,int[] time,List<int>[] graph,int node,int parent)
        {

            visited[node] = true;
            timeAtNode[node] = time[0]++;
            int currenttime = timeAtNode[node];
            foreach(int neighbor in graph[node])
            {
                if (neighbor == parent) continue;
                if (!visited[neighbor]) DFS(result,visited, timeAtNode, time, graph, neighbor, node);
                timeAtNode[node] = Math.Min(timeAtNode[node], timeAtNode[neighbor]);
                if (currenttime < timeAtNode[neighbor])
                    result.Add(new List<int>() { node, neighbor });
            }
        }
    }
}
