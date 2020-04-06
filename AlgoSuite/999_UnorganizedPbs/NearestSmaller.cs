using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class NearestSmaller
    {
        public List<int> prevSmaller(List<int> A)
        {
            if (A.Count == 0) return A;
            Stack<int> a_stk = new Stack<int>();
            for(int i=0;i<A.Count;i++)
            {
                while(a_stk.Count!=0&&a_stk.Peek()>=A[i])
                {
                    a_stk.Pop();
                }
                if(a_stk.Count==0)
                {
                    a_stk.Push(A[i]);
                    A[i] = -1;
                }
                else
                {
                    int temp = A[i];
                    A[i] = a_stk.Peek();
                    a_stk.Push(temp);
                }
               
            }
            return A;
        }
    }
}
