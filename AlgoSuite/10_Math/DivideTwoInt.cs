using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/divide-two-integers/
    /// <ID>039</ID>
    /// </summary>
    class DivideTwoInt
    {
        public int Divide(int dividend, int divisor)
        {
            int quotient = 0;
            bool sign_divisor = divisor < 0 ? true : false;
            bool sign_dividend = dividend < 0 ? true : false;
            divisor = divisor < 0 ? divisor : -divisor;
            dividend = dividend < 0 ? dividend : -dividend;
            if (divisor == -1)
            {
                if (dividend == int.MinValue)
                    return int.MaxValue;
                else
                    return sign_divisor ^ sign_dividend ? dividend : -dividend;
            }
            while (dividend - divisor <= 0)
            {
                quotient++;
                dividend -= divisor;
            }
            return sign_divisor ^ sign_dividend ? -quotient : quotient;
        }
    }
}
