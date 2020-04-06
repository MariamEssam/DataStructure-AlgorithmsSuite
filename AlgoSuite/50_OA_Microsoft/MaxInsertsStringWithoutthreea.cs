using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MaxInsertsStringWithoutthreea
    {
        public int find(string s)
        {
            int occurrence = 0;
            int num_a = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]!='a')
                {
                    num_a += (2 - occurrence);
                    occurrence = 0;
                }
                else
                {
                    occurrence++;
                    if (occurrence > 2) return -1;
                }
            }
            if(occurrence<2)
                num_a+= (2 - occurrence);
            return num_a;
        }
    }
}
