using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class AddDigitsC
    {
        public int AddDigits(int num)
        {
            while(num>9)
            {
                int tempnum = num;
                int sum = 0;
                while(tempnum!=0)
                {
                    sum += (tempnum % 10);
                    tempnum = tempnum / 10;
                }
                num = sum;
            }
            return num;
        }
    }
}
