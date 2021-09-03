using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PalindromePermutation
    {
        public bool CanPermutePalindrome(string s)
        {
            HashSet<char> chSet = new HashSet<char>();
            foreach(char ch in s)
            {
                if (chSet.Contains(ch))
                    chSet.Remove(ch);
                else
                    chSet.Add(ch);
            }
            return chSet.Count <= 1 ? true : false;
        }
    }
}
