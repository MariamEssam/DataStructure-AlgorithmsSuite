using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PerformStringShift
    {
        public string StringShift(string s, int[][] shift)
        {
            int moves = 0;
            int[] dir = new int[] { -1, 1 };
            for(int i=0;i<shift.Length;i++)
            {
                moves += (dir[shift[i][0]] * shift[i][1]);
            }
            StringBuilder build = new StringBuilder();
            moves = moves % s.Length;
            for(int i=0;i<s.Length;i++)
            {
                int index = - moves + i;
                index = index < 0 ? index + s.Length : index;
                build.Append(s[index%s.Length]);
            }
            return build.ToString();
        }
    }
}
