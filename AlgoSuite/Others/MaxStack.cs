using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/max-stack/
    /// <ID>1716</ID>
    /// </summary>
    public class MaxStack
    {
        Stack<int> stk = new Stack<int>();
        Stack<int> max_stk = new Stack<int>();
        /** initialize your data structure here. */
        public MaxStack()
        {
            
        }

        public void Push(int x)
        {
            stk.Push(x);
            if (max_stk.Count == 0 || max_stk.Peek() < x)
                max_stk.Push(x);
            else
                max_stk.Push(max_stk.Peek());
        }

        public int Pop()
        {
            max_stk.Pop();
            return stk.Pop();
        }

        public int Top()
        {
            return stk.Peek();
        }

        public int PeekMax()
        {
            return max_stk.Peek();
        }

        public int PopMax()
        {
            int max = max_stk.Peek();
            Stack<int> temp_stk = new Stack<int>();
            while (Top() != max)
                temp_stk.Push(Pop());
            Pop();
            while (temp_stk.Count != 0)
                Push(temp_stk.Pop());
            return max;
        }
    }

}