using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LargestTimeGivenDigits
    {
        int maxtime = -1;
        void Swap(int[]A,int i,int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
        void BuildTime(int[] A,int startIndex)
        {
            if(startIndex==3)
            {
                int hr = A[0] * 10 + A[1];
                int minutes = A[2] * 10 + A[3];
                int newtime = hr * 60 + minutes;
                if (hr < 24 && minutes < 60 && newtime > maxtime)
                    maxtime = newtime;
                return;
            }
            for(int i=startIndex;i<A.Length;i++)
            {
                Swap(A,startIndex, i);
                BuildTime(A, startIndex + 1);
                Swap(A, startIndex, i);
            }
        }
        public string LargestTimeFromDigits(int[] A)
        {
            StringBuilder build = new StringBuilder();
            BuildTime(A, 0);
            if (maxtime != -1)
            {
                build.Append(String.Format("{0:D2}:{1:D2}", maxtime / 60,maxtime % 60));
            }
            return build.ToString();
        }
    }
}
