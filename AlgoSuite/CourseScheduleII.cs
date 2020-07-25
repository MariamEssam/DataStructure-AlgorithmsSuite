using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class CourseScheduleII
    {
        static int WHITE = 1;
        static int GRAY = 2;
        static int BLACK = 3;

        bool isPossible;
        Dictionary<int, int> color;
        Dictionary<int, List<int>> adjList;
        List<int> topologicalOrder;

        private void init(int numCourses)
        {
            this.isPossible = true;
            this.color = new Dictionary<int, int>();
            this.adjList = new Dictionary<int, List<int>>();
            this.topologicalOrder = new List<int>();

            // By default all vertces are WHITE
            for (int i = 0; i < numCourses; i++)
            {
                this.color.Add(i, WHITE);
            }
        }

        private void dfs(int node)
        {

            // Don't recurse further if we found a cycle already
            if (!this.isPossible)
            {
                return;
            }

            // Start the recursion
            this.color.Add(node, GRAY);

            // Traverse on neighboring vertices
            foreach (int  neighbor in this.adjList[node])
            {
                if (this.color[neighbor] == WHITE)
                {
                    this.dfs(neighbor);
                }
                else if (this.color[neighbor] == GRAY)
                {
                    // An edge to a GRAY vertex represents a cycle
                    this.isPossible = false;
                }
            }

            // Recursion ends. We mark it as black
            this.color.Add(node, BLACK);
            this.topologicalOrder.Add(node);
        }

        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {

            this.init(numCourses);

            // Create the adjacency list representation of the graph
            for (int i = 0; i < prerequisites.Length; i++)
            {
                int dest = prerequisites[i][0];
                int src = prerequisites[i][1];
                List<int> lst = adjList[src];
                lst.Add(dest);
                adjList.Add(src, lst);
            }

            // If the node is unprocessed, then call dfs on it.
            for (int i = 0; i < numCourses; i++)
            {
                if (this.color[i] == WHITE)
                {
                    this.dfs(i);
                }
            }

            int[] order;
            if (this.isPossible)
            {
                order = new int[numCourses];
                for (int i = 0; i < numCourses; i++)
                {
                    order[i] = this.topologicalOrder[numCourses - i - 1];
                }
            }
            else
            {
                order = new int[0];
            }

            return order;
        }
    }
}
