using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PowerofFour
    {
        public bool IsPowerOfFour(int num)
        {
            if (num==0)
                return false;
            while (num % 4 == 0) num /= 4;
            return num == 1 ? true:false;
        }
    }
}
