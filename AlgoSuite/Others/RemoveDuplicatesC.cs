using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
    /// <ID>091</ID>
    /// </summary>
    class RemoveDuplicatesC
    {
        public string RemoveDuplicates(string S)
        {
            Stack<char> stk = new Stack<char>();
            foreach(char c in S)
            {
                if (stk.Count > 0 && stk.Peek() == c)
                    stk.Pop();
                else
                    stk.Push(c);
            }
            StringBuilder build = new StringBuilder();
            while(stk.Count!=0)
            {
                build.Insert(0,stk.Pop());
            }
            return build.ToString();
        }
    }
}
