using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ValidParenthese
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            int i = 0;
            while(i<s.Length)
            {
                char c = s[i];
                if (c == '(' || c == '[' || c == '{')
                    stack.Push(c);
                else
                {
                    char c_prev = stack.Pop();
                    if (!((c == ')' && c_prev == ')')
                    || (c == '}' && c_prev == '{')
                    || (c == ']' && c_prev == '[')))
                        return false;

                }
                i++;
            }
            if (stack.Count != 0)
                return false;
            return true;
        }
    }
}
