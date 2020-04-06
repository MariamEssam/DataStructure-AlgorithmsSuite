using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MeetingRoomII
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            int usedrooms = 0;
            int[] start = new int[intervals.Length];
            int[] end = new int[intervals.Length];
           
            for(int i=0;i<intervals.Length;i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];
            
            }
            Array.Sort(start);
            Array.Sort(end);
            int ptr_start = 0;
            int ptr_end = 0;
            while(ptr_start<intervals.Length)
            {
                if (end[ptr_end] > start[ptr_start])
                {
                    usedrooms++;

                }
                else
                    ptr_end++;
                ptr_start++;
            }
            return usedrooms;
        }
    }
}
