using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MaxPossibleValue
    {
        public int findMax(int N)
        {
            if (N == 0) return 50;
            bool sign = N < 0 ? true : false;
            int N_updated = Math.Abs(N);
            int index = 0;
            int digitcount = 0;
            while(N_updated!=0)
            {
                digitcount++;
                if(N_updated%10<5)
                {
                    index = digitcount;
                }
                N_updated = N_updated / 10;
            }
            N_updated = Math.Abs(N);
            int i = 0;
            int value = 0;
            while (i <= digitcount)
            {
                
                if (i==index)
                {
                    value += 5*(int)Math.Pow(10, i);
                }
                else
                {
                    value += (N_updated % 10)*(int)Math.Pow(10, i);
                    N_updated = N_updated / 10;
                }
                i++;
            }
            return sign?-value:value;
        }
    }
}
