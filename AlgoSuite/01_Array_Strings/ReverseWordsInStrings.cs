using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ReverseWordsInStrings
    {
        private void Reverse(char[] s,int i,int j)
        {
            while (i < j)
            {
                char c = s[i];
                s[i++] = s[j];
                s[j--] = c;
            }
        }
        public void ReverseWords(char[] s)
        {
            
            //Reverse the sentence
            Reverse(s, 0, s.Length-1);
            int ptr = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]==' ')
                {
                    Reverse(s, ptr, i - 1);
                    ptr = i + 1;
                }
            }
            Reverse(s, ptr, s.Length - 1);
        }
    }
}
