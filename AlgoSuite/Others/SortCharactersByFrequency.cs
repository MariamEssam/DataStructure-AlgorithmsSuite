using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/sort-characters-by-frequency/
    /// <ID>1451</ID>
    /// </summary>
    class SortCharactersByFrequency
    {
        public string FrequencySort(string s)
        {
            if (String.IsNullOrEmpty(s)) return s;
            char[] s_char = s.ToCharArray();
            Array.Sort(s_char);
            StringBuilder build = new StringBuilder();
            List<string> str_lst = new List<string>();
            build.Append(s_char[0]);
            for(int i=1;i<s_char.Length;i++)
            {
                if (s_char[i] == s_char[i - 1])
                    build.Append(s_char[i]);
                else
                {
                    str_lst.Add(build.ToString());
                    build.Clear();
                    build.Append(s_char[i]);
                }
            }
            str_lst.Add(build.ToString());
            build.Clear();
            str_lst=str_lst.OrderBy(m => m.Length).ToList();
            for (int i = str_lst.Count - 1; i >= 0; i--)
                build.Append(str_lst[i]);
            return build.ToString();
        }
    }
}
