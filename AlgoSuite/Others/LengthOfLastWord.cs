using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LengthOfLastWordC
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int ptr = s.Length - 1;
            int size = 0;
            while (ptr >= 0 && s[ptr] != ' ') { ptr--; size++; }
            return size;
        }
    }
}
