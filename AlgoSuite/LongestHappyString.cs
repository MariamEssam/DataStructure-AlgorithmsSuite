using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/longest-happy-string/
    /// <ID>21405</ID>
    /// </summary>
    class LongestHappyString
    {
        public string LongestDiverseString(int a, int b, int c)
        {
            StringBuilder build = new StringBuilder();
            int size = a + b + c;
            int A = 0, B = 0, C = 0;
            for (int i = 0; i < size; i++)
            {
                if ((a >= b && a >= c && A != 2) || (B == 2 && a > 0) || (C == 2 && a > 0))
                {
                    build.Append('a');
                    B = 0;
                    C = 0;
                    A++;
                    a--;
                }
                else if ((b >= a && b >= c && B != 2) || (A == 2 && b > 0) || (C == 2 && b > 0))
                {
                    build.Append('b');
                    A = 0;
                    C = 0;
                    B++;
                    b--;
                }
                else if ((c >= a && c >= b && C != 2) || (A == 2 && c > 0) || (B == 2 && c > 0))
                {
                    build.Append('c');
                    A = 0;
                    B = 0;
                    c--;
                    C++;
                }
            }
            return build.ToString();
        }
    }
}
