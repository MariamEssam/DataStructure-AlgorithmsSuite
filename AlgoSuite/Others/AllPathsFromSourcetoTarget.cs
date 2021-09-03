using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/all-paths-from-source-to-target/
    /// <ID>1797</ID>
    /// </summary>
    class AllPathsFromSourcetoTarget
    {
        IList<IList<int>> results;
        void FindPath(List<int> path, bool[] visited, int destination, int[][] graph)
        {
            if (visited[destination])
                return;
            visited[destination] = true;
            path.Add(destination);
            if (destination == graph.Length - 1)
            {
                results.Add(path);
            }
            else
            {
                foreach (int p in graph[destination])
                {
                    List<int> path_new = new List<int>(path);
                    FindPath(path_new, visited, p, graph);
                }
            }
        }
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            results = new List<IList<int>>();
            FindPath(new List<int>(), new bool[graph.Length], 0, graph);
            return results;
        }
    }
}
