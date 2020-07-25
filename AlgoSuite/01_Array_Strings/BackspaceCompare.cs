using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/backspace-string-compare/
    /// <ID>049</ID>
    /// </summary>
    class BackspaceCompareC
    {
        int findendIndex(char[] arr)
        {
            int index = -1;
            int ptr = 0;
            while(ptr<arr.Length)
            {
                if (arr[ptr] != '#')
                {
                    index++;
                    arr[index] = arr[ptr];
                }
                else
                {
                    if (index >= 0) index--;
                }
                ptr++;
            }
            return index;

        }
        public bool BackspaceCompare(string S, string T)
        {
            char[] s_arr = S.ToCharArray();
            char[] t_arr = T.ToCharArray();
            int s_index = findendIndex(s_arr);
            int t_index = findendIndex(t_arr);
            if (s_index == -1 && t_index == -1)
                return true;
            if (s_index != t_index) return false;
            for (int i = 0; i <= s_index; i++)
                if (s_arr[i] != t_arr[i]) return false;
            return true;
        }
    }
}

