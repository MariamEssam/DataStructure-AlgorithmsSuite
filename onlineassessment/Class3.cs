using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineassessment
{
    class Class3
    {
        public int solution(int N)
        {
            if (N == 0) return 50;
            bool sign = N < 0 ? true : false;
            N = Math.Abs(N);
            bool inserted = false;
            int digits = 0;
            int num = N;
            while(N!=0)
            {
                N = N / 10;
                digits++;
            }
            
            N = num;
            num = 0;
            while(digits!=0)
            {
                int curr = N / (int)Math.Pow(10, digits - 1);
                if (sign && !inserted && curr >= 5)
                {
                    inserted = true;
                    curr = 5;
                }
                else if (!sign && !inserted && curr <= 5)
                {
                    inserted = true;
                    curr = 5;
                }
                else
                {
                    digits--;
                    N = N - curr * (int)Math.Pow(10, digits);
                }
                num = num * 10 + curr;
            }
            return sign ? -num : num;
        }
    }
}
