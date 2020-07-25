using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LicenseKeyFormattingC
    {
        /// <summary>
        /// https://leetcode.com/problems/license-key-formatting/
        /// <ID>012</ID>
        /// </summary>


        public string LicenseKeyFormatting(string S, int K)
        {
            StringBuilder sb = new StringBuilder();
           for(int i=S.Length-1;i>=0;i--)
            {

                if (S[i] != '-')
                    sb.Insert(0,sb.Length % (K + 1) == K ? "-" : "").Insert(0,Char.ToUpper(S[i]));
            }
            return sb.ToString();
        }
    }
}
