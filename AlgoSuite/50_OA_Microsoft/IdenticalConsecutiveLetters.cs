using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class IdenticalConsecutiveLetters
    {
        public string RemoveThreeIdenticalletters(string str)
        {
            if (str.Length == 0)
                return "";
            char ch = str[0];
            int occurrence = 1;
            StringBuilder buid = new StringBuilder();
            buid.Append(ch);
            for(int i=1;i<str.Length;i++ )
            {
                if(str[i]==ch)
                {
                    if ((occurrence + 1) < 3)
                    {
                        buid.Append(str[i]);
                        occurrence++;
                    }
                }
                else
                {
                    ch = str[i];
                    occurrence = 1;
                    buid.Append(str[i]);
                }
            }
            return buid.ToString();
        }
    }
}
