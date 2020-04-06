using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class RotateStringC
    {
        public bool RotateString(string A, string B)
        {
            if (A.Length != B.Length)
                return false;
            if (A.Length == 0)
                return true;
            if ((A + A).Contains(B)) return true;
            return false;
        }
    }
}
