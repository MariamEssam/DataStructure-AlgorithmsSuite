using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class HotelBookingsPossible
    {
        public int hotel(List<int> A, List<int> B, int C)
        {
            A.Sort();
            B.Sort();
            int ptr_start = 0;
            int ptr_end = 0;
            int numberofrooms = 0;
            while(ptr_start<A.Count)
            {
                if (A[ptr_start] < B[ptr_end])
                {
                    numberofrooms++;
                }
                else
                    ptr_end++;
                ptr_start++;
            }
            return numberofrooms <= C?1:0;
        }
    }
}
