using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LexicographicallySmallestStr
    {
        public string RemoveChar(string word)
        {
           for(int i=0;i<word.Length;i++)
            {
                if (i == word.Length - 1)
                    return word.Remove(i, 1);
                if (word[i] > word[i + 1])
                    return word.Remove(i, 1);
            }
            return "";
        }
    }
}
