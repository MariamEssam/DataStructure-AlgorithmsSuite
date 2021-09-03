using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/string-to-integer-atoi/
    /// <ID>1008</ID>
    /// </summary>
    class StringToInt
    {
        public int MyAtoi(string str)
        {
            long result = 0;
            int ptr = 0;
            int sign = 1;
            
            //Find First digit or sign
            while(ptr<str.Length)
            {
                if (str[ptr] >= '0' && str[ptr] <= '9')
                    break;
                if (str[ptr] == '+')
                    break;
                if (str[ptr] == '-')
                {
                    sign = -1;
                    break;
                }
                if (str[ptr] != ' ')
                    return 0;
                ptr++;
            }
            while (ptr<str.Length)
            {
                if (str[ptr] >= '0' && str[ptr] <= '9')
                {
                    result = result * 10 + str[ptr]-'0';
                    if (result > int.MaxValue)
                        return int.MaxValue;
                    if (result < int.MinValue)
                        return int.MinValue;
                }
                else
                    break;
                ptr++;
            }
            return (int)result*sign;
        }
    }
}
