using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// 
    /// </summary>
    class PowerReminder
    {
        long helper(int x, int n, int d)
        {
            if (n == 0)
                return 1;
            x = x % d;
            long half = helper(x, n / 2, d);
            half = half % d;
            long val= (half * half) % d;
            if (n % 2 != 0)
            {
                return (val * x)%d;
            }
            return val;
        }
        public int pow(int x, int n, int d)
        {
            if (x == 0) return 0;

            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }
            int val = (int)helper(x, n, d);
            return val < 0 ? val + d : val;
        }
    }
}
