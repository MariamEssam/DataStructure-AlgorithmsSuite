using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ReplaceEmptySpace
    {
        public void ReplaceSpace(char[] str,int Trueength)
        {
            int index = str.Length - 1;
            int ptr = Trueength - 1;
            while(index>=0)
            {
                if(str[ptr]==' ')
                {
                    str[index] = '0';
                    str[index - 1] = '2';
                    str[index - 2] = '%';
                    index -= 3;
                }
                else
                {
                    str[index--] = str[ptr];
                }
                ptr--;
            }
        }

    }
}
