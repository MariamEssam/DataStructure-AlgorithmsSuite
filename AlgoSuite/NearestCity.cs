using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/808374/Amazon-or-OA-2020-or-Nearest-City
    /// <ID>5011</ID>
    /// </summary>
    class CompareKeyPairs : IComparer<KeyValuePair<string, int>>
    {
        public int Compare(KeyValuePair<string, int> x, KeyValuePair<string, int> y)
        {
            if (x.Value < y.Value)
            {
                return -1;
            }
            else if (x.Value > y.Value)
            {
                return 1;
            }
            else
                return x.Key.CompareTo(y.Key);
        }
    }
    class NearestCity
    {
        public String[] findNearestCities(int numOfCities, String[] cities, int[] xCoordinates, int[] yCoordinates, int numOfQueries,
                                 String[] queries)
        {
            string[] res = new string[numOfQueries];
            Dictionary<string, int> dicCities = new Dictionary<string, int>();
            for (int i = 0; i < cities.Length; i++)
                dicCities.Add(cities[i], i);
            IComparer<KeyValuePair<string, int>> comp = new CompareKeyPairs();
            MinHeap<KeyValuePair<string, int>>[] heaparray = new MinHeap<KeyValuePair<string, int>>[cities.Length];
            for(int i=0;i<numOfCities;i++)
                heaparray[i] = new MinHeap<KeyValuePair<string, int>>(comp);
            for (int i=0;i<xCoordinates.Length;i++)
            {
                for(int j=0;j<xCoordinates.Length;j++)
                {
                    if(i!=j&&xCoordinates[i]==xCoordinates[j])
                    {
                        
                        int d = Math.Abs(xCoordinates[i] - xCoordinates[j]) + Math.Abs(yCoordinates[i] - yCoordinates[j]);
                        heaparray[i].add(new KeyValuePair<string, int>(cities[j], d));
                    }
                }
            }
            for (int i = 0; i < yCoordinates.Length; i++)
            {
                for (int j = 0; j < yCoordinates.Length; j++)
                {
                    if (i != j && yCoordinates[i] == yCoordinates[j])
                    {
                        int d = Math.Abs(xCoordinates[i] - xCoordinates[j]) + Math.Abs(yCoordinates[i] - yCoordinates[j]);
                        heaparray[i].add(new KeyValuePair<string, int>(cities[j], d));
                    }
                }
            }
            for(int i=0;i<numOfQueries;i++)
            {
                int index = dicCities[queries[i]];
                if (heaparray[index].size != 0)
                {
                    res[i] = heaparray[index].poll().Key;
                }
                else
                    res[i] = "None";
            }
            return res;
        }
    }
}
