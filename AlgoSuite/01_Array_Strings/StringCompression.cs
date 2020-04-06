using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class StringCompression
    {
        public int Compress(char[] chars)
        {
            int anchor = 0, writer = 0;
            
            for(int reader=0;reader<chars.Length; reader++)
            {
                if(reader+1==chars.Length||chars[reader]!=chars[reader+1])
                {
                    chars[writer++] = chars[anchor];
                    if(reader>anchor)
                    {
                        foreach(char c in(reader-anchor+1).ToString().ToCharArray())
                        {
                            chars[writer++] = c;
                        }
                    }
                    anchor = reader + 1;
                }
            }
            return anchor;
        }
    }
}
