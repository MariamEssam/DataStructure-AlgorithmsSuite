using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class Sort2DArray : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return x[2].CompareTo(y[2]);
        }
    }
    class ConnectCitiesMinimumCost
    {
        int[] parent;
        int n;
        int find(int city)
        {
            if (parent[city] == city)
                return city;
            parent[city] = find(parent[city]);//path comperession
            return parent[city];
        }
        void union(int city1,int city2)
        {
            int p1 = parent[city1];
            int p2 = parent[city2];

            if (p1!=p2)
            {
                parent[p2] = p1;
                n--;
            }
        }
        public int MinimumCost(int N, int[][] connections)
        {
            int cost = 0;
            //We identify the sets by the parent. Cities have same parent are from
            //the same set.
            parent = new int[N + 1];
            n = N;
            //Each One point to itself as the parent
            for(int i=0;i<=N;i++)
            {
                parent[i] = i;
            }

            Array.Sort(connections, (a,b)=>(a[2]-b[2]));
            foreach(var connec in connections)
            {
                int city1 = connec[0], city2 = connec[1];
                //We check if they are from the same set or not
                //We do that by checking the parent for each city set
                if(find(city1)!=find(city2))
                {
                    cost += connec[2];
                    union(city1,city2);
                }
            }
            return n == 1 ? cost : -1;
        }
    }
}
