using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class NumSpecialEquivGroupsStrings
    {
        public int NumSpecialEquivGroups(string[] A)
        {
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < A.Length; i++)
            {
                int[] odd = new int[26];
                int[] even = new int[26];
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (j % 2 == 0)
                        even[A[i][j] - 'a']++;
                    else
                        odd[A[i][j] - 'a']++;
                }
                StringBuilder build = new StringBuilder();
                build.Append(String.Join(",", even)).Append(String.Join(",", odd));
                if (!set.Contains(build.ToString())) set.Add(build.ToString());
            }
            return set.Count;
        }
    }
}
