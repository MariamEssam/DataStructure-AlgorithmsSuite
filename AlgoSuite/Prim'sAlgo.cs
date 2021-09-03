using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PrimsAlgo
    {
        int v =0;
        int getMinInex(bool[] mstset,int[] key)
        {
            int minIndex = -1, min = int.MaxValue;
            for(int i=0;i<v;i++)
            {
                if(mstset[i]==false&&key[i]<min)
                {
                    minIndex = i;
                    min = key[i];
                }
            }
            return minIndex;
        }
        void printMST(int[] parent,int[] weight)
        {
            for(int i=1;i<v;i++)
            {
                Console.WriteLine(parent[i] + "--" + i + "\t" + weight[i]);
            }
        }
        public void primMST(int[,] graph)
        {
            v = graph.GetLength(0);
            int[] parent = new int[v];
            int[] weight = new int[v];
            bool[] mstset = new bool[v];

            for(int i=0;i<v;i++)
            {
                weight[i] = int.MaxValue;
            }
            weight[0] = 0;
            parent[0] = -1;
            for(int i=1;i<v;i++)
            {
                int minIndex = getMinInex(mstset, weight);
                mstset[minIndex] = true;
                for(int j=0;j<v;j++)
                {
                    if(mstset[j]==false&&graph[minIndex,j]!=0&&weight[j]>graph[minIndex,j])
                    {
                        parent[j] = minIndex;
                        weight[j] = graph[minIndex, j];
                    }
                }
            }
            printMST(parent, weight);
        }
    }
}
