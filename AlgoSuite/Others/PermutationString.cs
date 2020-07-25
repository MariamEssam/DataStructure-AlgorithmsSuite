using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PermutationString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s2.Length < s1.Length)
                return false;
            int ptr1 = -1, ptr2 = 0;
            Dictionary<char, int> s2_dic = new Dictionary<char, int>();
            foreach (char c in s1)
            {
                if (!s2_dic.ContainsKey(c))
                {
                    s2_dic.Add(c, 0);
                }
                s2_dic[c]++;
            }
            while (ptr2 < s2.Length)
            {
                if (s2_dic.ContainsKey(s2[ptr2]))
                {
                    if (ptr1 == -1)
                        ptr1 = ptr2;

                    --s2_dic[s2[ptr2]];
                    if (s2_dic[s2[ptr2]] == 0)
                        s2_dic.Remove(s2[ptr2]);
                    ptr2++;
                }
                else
                {
                    if (ptr1 != -1)
                    {
                        if (ptr1 <= ptr2)
                        {
                            if (!s2_dic.ContainsKey(s2[ptr1]))
                                s2_dic.Add(s2[ptr1], 0);
                            s2_dic[s2[ptr1]]++;
                            ptr1++;
                        }
                        else
                        {
                            ptr1 = -1;

                        }
                    }
                    else
                        ptr2++;
                }

                if (s2_dic.Count == 0)
                    return true;
            }
            return false;
        }
    }
}
