using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FindAllAnagrams
    {

        public IList<int> FindAnagrams(string s, string p)
        {
            IList<int> result = new List<int>();
            if (s.Length < p.Length)
                return result;
            int[] p_arr = new int[26];
            int[] s_arr = new int[26];
            foreach (char c in p)
                p_arr[c - 'a']++;
            for (int i = 0; i < p.Length; i++)
            {
                s_arr[s[i] - 'a']++;
            }
            if (Compare(s_arr, p_arr))
                result.Add(0);
            for (int i = p.Length; i < s.Length; i++)
            {
                s_arr[s[i] - 'a']++;
                s_arr[s[i - p.Length] - 'a']--;
                if (Compare(s_arr, p_arr))
                    result.Add(i - p.Length + 1);
            }

            return result;
        }
        bool Compare(int[] arr1, int[] arr2)
        {
            return Enumerable.SequenceEqual(arr1, arr2);
            //for (int i = 0; i < arr1.Length; i++)
            //    if (arr1[i] != arr2[i])
            //        return false;
            //return true;
        }
    }
}
