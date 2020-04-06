using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite.AlgoGraph
{
    /// <summary>
    /// <tag>Graph</tag>
    /// <ID></ID>
    /// <code>000004</code>
    /// <Link>https://www.geeksforgeeks.org/graph-and-its-representations/</Link>
    /// </summary>
    class Graph
    {
        List<LinkedList<int>> graph = new List<LinkedList<int>>();
        int vertix = 0;
        public Graph(int v)
        {
            vertix = v;
            for (int i = 0; i < v; i++)
            {
                graph.Add(new LinkedList<int>());
            }
        }
        public void addEdgeUndirected(int src, int target)
        {
            graph[src].AddLast(target);
            graph[target].AddLast(src);
        }
        public void addEdgeDirected(int src, int target)
        {
            graph[src].AddLast(target);
        }
        public void print()
        {
            for (int i = 0; i < vertix; i++)
            {
                LinkedListNode<int> node = graph[i].First;
                while (node != null)
                {
                    Console.Write(node.Value);
                    node = node.Next;
                    if (node != null)
                        Console.Write("->");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// <tag>Graph</tag>
        /// <ID></ID>
        /// <code>000005</code>
        /// <Link>https://www.geeksforgeeks.org/breadth-first-search-or-bfs-for-a-graph/</Link>
        /// </summary>
        public void BFS(int start)
        {
            LinkedListNode<int> Node = graph[start].First;
            bool[] visited = new bool[vertix];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            while (queue.Count != 0)
            {
                int val = queue.Dequeue();
                visited[val] = true;
                Console.WriteLine(val);
                Node = graph[val].First;
                while (Node != null)
                {
                    if (!visited[Node.Value])
                        queue.Enqueue(Node.Value);
                    Node = Node.Next;
                }
            }
        }
        void DFSUtil(bool[] visited,int v)
        {
            visited[v] = true;
            Console.WriteLine(v);
            LinkedListNode<int> node = graph[v].First;
            while(node!=null)
            {
                if(!visited[node.Value])
                   DFSUtil(visited, node.Value);
                node = node.Next;
            }
        }
        /// <summary>
        /// Traverse reacheable nodes.
        /// <tag>Graph</tag>
        /// <ID></ID>
        /// <code>000006</code>
        /// <Link>https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/</Link>
        /// </summary>
        public void DFS(int start)
        {
            bool[] visited = new bool[vertix];
            DFSUtil(visited, start);
        }
        /// <summary>
        /// Same as the other DFS function we traverse all unreachable nodes
        /// <tag>Graph</tag>
        /// <ID></ID>
        /// <code>000006</code>
        /// <Link>https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/</Link>
        /// </summary>
        public void DFS()
        {
            bool[] visited = new bool[vertix];
            for (int i = 0; i < vertix; i++)
            {
                if(!visited[i])
                   DFSUtil(visited, i);
            }
        }
        bool cyclicUtils(bool[] visited,bool[] seen,int v)
        {
            if (seen[v] == true) return true;
            if (visited[v] == true) return false;
            visited[v] = true;
            seen[v] = true;
            LinkedListNode <int> node = graph[v].First;
            bool cyclic = false;
            while(node!=null)
            {
                cyclic = cyclicUtils(visited, seen, node.Value);
                if (cyclic) return true;
                node = node.Next;
            }
            seen[v] = false;
            return false;
        }
        public bool IsCyclic()
        {
            bool[] visited = new bool[vertix];
            bool[] seen = new bool[vertix];
            bool Iscyclic = false;
            for(int i=0;i<vertix;i++)
            {
                Iscyclic = cyclicUtils(visited, seen, i);
                if (Iscyclic)
                    return true;
            }
            return false;
        }
        bool CyclicUndiUtils(bool[] visited,int v,int parent)
        {

         
                visited[v] = true;
                LinkedListNode<int> node = graph[v].First;
                while (node != null)
                {
                if (!visited[node.Value])
                {
                    bool iscyclic = CyclicUndiUtils(visited, node.Value, v);
                    if (iscyclic) return true;
                    
                }
                else if (node.Value != parent)
                    return true;
                node = node.Next;
            }
            
            
            return false;

        }
        public bool IsCyclicUndirected()
        {
            bool[] visited = new bool[vertix];
            bool isCyclic = false;
            for(int i=0;i<vertix;i++)
            {
                if (!visited[i])
                {
                    isCyclic = CyclicUndiUtils(visited, i, -1);
                    if (isCyclic) return true;
                }
            }
            return false;
        }
        void TopologicalSortUtils(bool[] visited,int v,Stack<int> stk)
        {
            if (visited[v]) return;
            visited[v] = true;
          
            LinkedListNode<int> node = graph[v].First;
            while(node!=null)
            {
                TopologicalSortUtils(visited, node.Value, stk);
                node = node.Next;
            }
            stk.Push(v);
        }
        public void TopologicalSort()
        {
            bool[] visited = new bool[vertix];
            Stack<int> stk = new Stack<int>();
            for (int k = 0; k < vertix; k++)
            {
                for (int i = 0; i < vertix; i++)
                {
                    if (!visited[i]) TopologicalSortUtils(visited, i, stk);

                }
                while (stk.Count != 0)
                    Console.Write(stk.Pop() + " ");

            }
        }
    }
}
