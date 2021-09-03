using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// <ID>1020</ID>
    /// </summary>
    class ValidParenthese
    {
        //Using dictionnary
        public bool IsValid(string s)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>() { { ')', '(' }, { '}', '{' }, { ']', '[' } };
            Stack<char> stk = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i])) stk.Push(s[i]);
                else
                {
                    if (stk.Count == 0) return false;
                    char c = stk.Pop();
                    if (dic[s[i]] != c) return false;
                }
            }
            return stk.Count == 0 ? true : false;
        }
        public bool IsValid2(string s)
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
