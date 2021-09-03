using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/min-stack/
    /// <ID>1155</ID>
    /// </summary>
    public class MinStack
    {
        Stack<int> min;
        Stack<int> stk;
        /** initialize your data structure here. */
        public MinStack()
        {
            min = new Stack<int>();
            stk = new Stack<int>();
        }

        public void Push(int x)
        {
            if (min.Count == 0 || min.Peek() >= x)
                min.Push(x);
            stk.Push(x);
        }

        public void Pop()
        {
            if (stk.Peek() == min.Peek())
                min.Pop();
            stk.Pop();
        }

        public int Top()
        {
            if (stk.Count == 0) return -1;
            return stk.Peek();
        }

        public int GetMin()
        {
            if (min.Count == 0) return -1;
            return min.Peek();
        }
    }
}
