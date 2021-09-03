using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
    /// <ID>2047</ID>
    /// </summary>
    class RemoveAdjacentDuplicates
    {
        //Stack
        public string RemoveDuplicates(string S)
        {
            StringBuilder build = new StringBuilder();
            Stack<char> stk = new Stack<char>();
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (stk.Count != 0 && stk.Peek() == S[i])
                {
                    stk.Pop();
                }
                else
                {
                    stk.Push(S[i]);
                }
            }
            while (stk.Count != 0)
                build.Append(stk.Pop());
            return build.ToString();
        }
        //Two pointers
        public string RemoveDuplicates2(string S)
        {
            int ptr1 = 0, ptr2 = 0;
            char[] ch = S.ToArray();
            while(ptr2<S.Length)
            {
                ch[ptr1] = ch[ptr2];
                if(ptr1>0&&ch[ptr1]==ch[ptr1-1])
                {
                    ptr1 -= 2;
                }
                ptr1++;
            }
            return new string(ch, 0, ptr1);
        }
    }
}
