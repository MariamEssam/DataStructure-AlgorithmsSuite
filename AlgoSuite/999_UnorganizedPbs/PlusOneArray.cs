using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/
    /// <ID>031</ID>
    /// </summary>
    class PlusOneArray
    {
        public int[] PlusOne(int[] digits)
        {
            int carryon = 1;
            int i = digits.Length - 1;
            while (carryon == 1 && i >= 0)
            {
                if (digits[i] == 9)
                    digits[i] = 0;
                else
                {
                    digits[i]++;
                    carryon = 0;
                }
               i--;
            }
           if(carryon==1)
            {
                digits = new int[digits.Length + 1];
                digits[0] = 1;
            }
           
           return digits;
        }
    }
}
