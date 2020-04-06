using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class StringWithout3IdenticalConsecutiveLetters
    {
        public int MinimumSwaps(string str)
        {
            int ptr = 0;
            int numberofSwaps = 0;
            int count = 0;
            while(ptr<str.Length)
            {
                count++;
                if(ptr+1==str.Length||str[ptr]!=str[ptr+1])
                {
                    numberofSwaps += (count / 3);
                    count = 0;
                }
                ptr++;
            }
            return numberofSwaps;
        }
    }
}
