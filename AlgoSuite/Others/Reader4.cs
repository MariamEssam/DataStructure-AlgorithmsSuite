using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class Reader4
    {
        int read4(char[] buf) { return 0; }
        public int Read(char[] buf, int n)
        {
            int copiedcchar = 0, readchar = 4;
            char[] buf4 = new char[4];
            while(readchar==4&&copiedcchar<n)
            {
                readchar = read4(buf4);
                for(int i=0;i<readchar;i++)
                {
                    if (copiedcchar == n) return copiedcchar;
                    buf[copiedcchar] = buf4[i];
                    copiedcchar++;
                }
            }
            return copiedcchar;
        }
    }
}
