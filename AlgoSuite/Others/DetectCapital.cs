using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class DetectCapital
    {
        bool AllLettersSmall(int start,int end,string word)
        {
            for (int i = start; i < end; i++)
                if (word[i] < 'a' || word[i] > 'z')
                    return false;
            return true;
        }
        bool AllLettersCapital(int start, int end, string word)
        {
            for (int i = start; i < end; i++)
                if (word[i] < 'A' || word[i] > 'Z')
                    return false;
            return true;
        }
        public bool DetectCapitalUse(string word)
        {
            if (word.Length <= 1)
                return true;
            if (AllLettersSmall(0, word.Length, word) || AllLettersCapital(0, word.Length, word))
                return true;
            if (AllLettersSmall(1, word.Length, word) && AllLettersCapital(0, 1, word))
                return true;
            return false;
        }
    }
}
