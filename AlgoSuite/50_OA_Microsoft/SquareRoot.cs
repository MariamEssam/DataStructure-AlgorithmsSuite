using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SquareRoot
    {
        
        public int MySqrt(int x)
        {
            if (x < 2) return x;
            int l = 1, h = x/2;
            while(l<=h)
            {
                int mid = (l + h) / 2;
                long val = (long)mid *(long)mid;
                if(val<x)
                {
                    l = mid + 1;
                }
                else if(val>x)
                {
                    h = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return h;
        }
    }
}
