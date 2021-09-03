using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FindTrios
    {
        int minproduct = -1;
        void getTrios(int lvl,int numofChild,bool[] visited,int node, LinkedList<int>[] graph,int parent)
        {
            if(lvl==3&&visited[node])
            {
                if(minproduct == -1|| minproduct > (numofChild-2*lvl))
                {
                    minproduct = numofChild - 2 * lvl;
                }
            }
            else if(lvl<3)
            {
                LinkedListNode<int> nextnode = graph[node].First;
                visited[node] = true;
                while (nextnode != null)
                {
                    if(nextnode.Value!=parent)
                        getTrios(lvl+1, numofChild+graph[node].Count, visited, nextnode.Value,graph,node);
                    
                    nextnode = nextnode.Next;
                }
                visited[node] = false;
            }
        }
        public int getMinScore(int productnode,int producedges,int[] product_from,int[] product_to)
        {
            LinkedList<int>[] graph = new LinkedList<int>[productnode + 1];
            bool[] visited = new bool[productnode + 1];
            for(int i=0;i<producedges;i++)
            {
                if (graph[product_from[i]] == null) graph[product_from[i]] = new LinkedList<int>();
                if (graph[product_to[i]] == null) graph[product_to[i]] = new LinkedList<int>();
                graph[product_from[i]].AddLast(product_to[i]);
                graph[product_to[i]].AddLast(product_from[i]);
            }
            for(int i=1;i<productnode;i++)
            {
                LinkedListNode<int> nextnode = graph[i].First;
                visited[i] = true;
                while(nextnode!=null)
                {
                    if(nextnode.Value>i)
                        getTrios(1, graph[i].Count, visited, nextnode.Value,graph,i);
                    
                    nextnode = nextnode.Next;
                }
                visited[i] = false;
            }
            return minproduct;
        }
    }
}
