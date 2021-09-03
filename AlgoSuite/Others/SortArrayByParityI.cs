using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SortArrayByParityI
    {
        public int[] SortArrayByParity(int[] A)
        {
            int odd_ptr = A.Length - 1;
            int even_ptr = 0;
            while(even_ptr<odd_ptr)
            {
                if(A[even_ptr]%2==0)
                {
                    even_ptr++;
                }
                else
                {
                    int temp = A[even_ptr];
                    A[even_ptr] = A[odd_ptr];
                    A[odd_ptr] = temp;
                    odd_ptr--;
                }
            }
            return A;
        }
    }
}
