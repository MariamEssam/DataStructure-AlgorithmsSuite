using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class Compare : IComparer<string>
    {
        int IComparer<string>.Compare(string s1, string s2)
        {
            {
                string[] split1 = s1.Split(null, 2);
                string[] split2 = s2.Split(null, 2);
                bool isDigit1 = Char.IsDigit(split1[1][0]);
                bool isDigit2 = Char.IsDigit(split2[1][0]);
                if (!isDigit1 && !isDigit2)
                {
                    int cmp = split1[1].CompareTo(split2[1]);
                    if (cmp != 0)
                        return cmp;
                    return split1[0].CompareTo(split2[0]);
                }

                if (!isDigit1 && isDigit2)
                    return -1;
                else if (!isDigit2 && isDigit1)
                    return 1;
                return 0;
            }
        }
    }
    class ReorderDataLogFiles
    {
       
        public string[] ReorderLogFiles(string[] logs)
        {
            var CompareStrings = new Compare();
            return logs.OrderBy(x=>x, CompareStrings).ToArray();
          
        }
        
    }
}
