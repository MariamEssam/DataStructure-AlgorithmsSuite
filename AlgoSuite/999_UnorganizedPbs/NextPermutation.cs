using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class NextPermutation
    {
        public List<int> nextPermutation(List<int> A)
        {
            if (A.Count <= 1) return A;
            int index = A.Count - 2;
            while(index>=0&& A[index]>=A[index+1])
            {
                index--;
            }
            if(index>=0)
            {
                int ptr = index;
                while(ptr<A.Count -1&&A[index]<A[ptr+1])
                {
                    ptr++;
                }
                swap(A, index, ptr);
            }
            reverse(A, index + 1);
            return A;
        }
        void swap(List<int> A,int i,int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
        void reverse(List<int> A,int startindex)
        {
            int endindex = A.Count - 1;
            while(startindex<endindex)
            {
                swap(A, startindex, endindex);
                startindex++;
                endindex--;
            }
        }
    }
}
