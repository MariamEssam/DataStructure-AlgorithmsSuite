using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/add-strings/
    /// <ID>145</ID>
    /// </summary>
    class AddStringsC
    {
        public string AddStrings(string num1, string num2)
        {
            StringBuilder build = new StringBuilder();
            int ptr_1 = num1.Length-1, ptr2=num2.Length-1;
            int carry = 0;
            while(ptr_1>=0||ptr2>=0)
            {
                int val1 = 0, val2 =0;
                if (ptr_1>=0)
                    val1 = int.Parse(num1[ptr_1--].ToString());
                if (ptr2>=0)
                    val2 = int.Parse(num2[ptr2--].ToString());
                build.Insert(0,((val1+val2+carry)%10).ToString());
                carry = (val1 + val2 + carry) / 10;
            }
            if (carry == 1) build.Insert(0, carry);
            return build.ToString();
        }
    }
}
