using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/ransom-note/
    /// <ID>060</ID>
    /// </summary>
    class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
                return false;
            int[] magazineletters = new int[128];
            foreach (var c in magazine)
                magazineletters[c]++;
            foreach(var c in ransomNote)
            {
                magazineletters[c]--;
                if (magazineletters[c] < 0) return false;
            }
            return true;
        }
    }
}
