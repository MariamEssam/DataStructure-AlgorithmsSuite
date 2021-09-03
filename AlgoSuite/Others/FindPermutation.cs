using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FindPermutationC
    {
        public int[] FindPermutation(string s)
        {
            int[] res = new int[s.Length + 1];
            int index = 0;
            Stack<int> stk = new Stack<int>();
            for (int i=0;i<s.Length;i++)
            {
                stk.Push(i + 1);
                while (s[i] == 'I' && stk.Count != 0)
                {
                    res[index++] = stk.Pop();
                }
            }
            stk.Push(s.Length + 1);
            res[index++] = stk.Pop();
            while (stk.Count != 0)
            {
                res[index++] = stk.Pop();
            }
            return res;
        }
    }
}
