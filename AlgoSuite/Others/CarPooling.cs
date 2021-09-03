using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class CarPoolingC
    {
        //public boolean carPooling(int[][] trips, int capacity)
        //{
        //    Map<Integer, Integer> timestamp = new TreeMap<>();
        //    for (int[] trip : trips)
        //    {
        //        int start_passenger = timestamp.getOrDefault(trip[1], 0) + trip[0];
        //        timestamp.put(trip[1], start_passenger);

        //        int end_passenger = timestamp.getOrDefault(trip[2], 0) - trip[0];
        //        timestamp.put(trip[2], end_passenger);
        //    }
        //    int ued_capacity = 0;
        //    for (int passenger_change : timestamp.values())
        //    {
        //        ued_capacity += passenger_change;
        //        if (ued_capacity > capacity)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        public bool CarPooling(int[][] trips, int capacity)
        {
            int[] timestamp = new int[1001];
            int currcapaity = 0;
            for(int i=0;i<trips.Length;i++)
            {
                timestamp[trips[i][1]] += trips[i][0];
                timestamp[trips[i][2]] -= trips[i][0];
            }

            for(int i=0;i<timestamp.Length;i++)
            {
                currcapaity += timestamp[i];
                if (currcapaity > capacity) return false;
            }
            return true;
        }
        public bool CarPooling_Map(int[][] trips, int capacity)
        {
            SortedDictionary<int, int> timestamp = new SortedDictionary<int, int>();
            int currcapacity = 0;

            for(int i=0;i<trips.Length;i++)
            {
                if (!timestamp.ContainsKey(trips[i][1]))
                    timestamp.Add(trips[i][1], 0);
                if (!timestamp.ContainsKey(trips[i][2]))
                    timestamp.Add(trips[i][2], 0);
                timestamp[trips[i][1]] += trips[i][0];
                timestamp[trips[i][2]] -= trips[i][0];
            }
          
            foreach(var item in timestamp)
            {
                currcapacity += item.Value;
                if (currcapacity > capacity) return false;
            }

            return true;
        }
        public bool CarPooling_Mariam(int[][] trips, int capacity)
        {
            int[][] startIndex = new int[trips.Length][];
            int[][] endIndex = new int[trips.Length][];
            int ptr1 = 0, ptr2 = 0;
            int currCapcity = 0;

            for (int i=0;i<trips.Length;i++)
            {
                startIndex[i] = new int[2];
                startIndex[i][0] = trips[i][1];
                startIndex[i][1] = trips[i][0];
                endIndex[i] = new int[2];
                endIndex[i][0] = trips[i][2];
                endIndex[i][1] = trips[i][0];
            }

            startIndex = startIndex.OrderBy(y => y[0]).ToArray();
            endIndex = endIndex.OrderBy(y => y[0]).ToArray();

            while(ptr1<trips.Length)
            {
                if(startIndex[ptr1][0]<endIndex[ptr2][0])
                {
                    currCapcity += startIndex[ptr1][1];
                    ptr1++;
                }
                if(startIndex[ptr1][0] > endIndex[ptr2][0])
                {
                    currCapcity -= endIndex[ptr2][1];
                    ptr2++;
                }
               else
                {
                    currCapcity += startIndex[ptr1][1];
                    ptr1++;
                    currCapcity -= endIndex[ptr2][1];
                    ptr2++;
                }
                if (currCapcity > capacity)
                    return false;
            }
            return true;
        }
    }
}
