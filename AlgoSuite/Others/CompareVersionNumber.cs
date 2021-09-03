using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class CompareVersionNumber
    {
        public int CompareVersion(string version1, string version2)
        {
            string[] str1 = version1.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            string[] str2 = version2.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            int max = Math.Max(str1.Length, str2.Length);
            
            for (int i=0;i<max;i++)
            {
                int n1 = i < str1.Length ? int.Parse(str1[i]) : 0;
                int n2 = i < str2.Length ? int.Parse(str2[i]) : 0;
                if (n1 != n2)
                    return n1 > n2 ? 1 : -1;
            }
            return 0;
        }
    }
}
