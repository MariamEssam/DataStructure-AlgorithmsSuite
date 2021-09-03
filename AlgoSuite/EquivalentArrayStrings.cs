using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// <ID>2662</ID>
    /// https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
    /// </summary>
    class EquivalentArrayStrings
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            int ptr1 = 0, ptr2 = 0;
            int chptr1 = 0, chptr2 = 0;
            while(ptr1<word1.Length&&ptr2<word2.Length)
            {
                if (word1[ptr1][chptr1++] != word2[ptr2][chptr2++])
                    return false;
                //Update first pointer
                if(chptr1==word1[ptr1].Length)
                {
                    chptr1 = 0;
                    ptr1++;
                }
                //Update Second pointer
                if (chptr2 == word2[ptr2].Length)
                {
                    chptr2 = 0;
                    ptr2++;
                }
            }

            if(ptr1==word1.Length&&ptr2==word2.Length)
               return true;
            return false;
        }
    }
}
