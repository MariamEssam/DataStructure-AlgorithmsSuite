using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/ugly-number-ii/
    /// <ID>082</ID>
    /// </summary>
    public class Ugly
    {
        const int MAX_NUM = 1690;
        public int[] num = new int[MAX_NUM];
        public Ugly()
        {
            num[0] = 1;
            int i2 = 0, i3 = 0, i5 = 0;
            for (int i = 1; i < MAX_NUM; i++)
            {
                int smallest = Math.Min(2 * num[i2], Math.Min(3 * num[i3], 5 * num[i5]));
                if (2 * num[i2] == smallest) i2++;
                if (3 * num[i3] == smallest) i3++;
                if (5 * num[i5] == smallest) i5++;
                num[i] = smallest;
            }
        }
    }
    class UglyNumberII
    {
        public static Ugly u = new Ugly();
        public int NthUglyNumber(int n)
        {
            return u.num[n - 1];
        }
    }
}
