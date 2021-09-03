using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/happy-number/
    /// <ID>1202</ID>
    /// </summary>
    class HappyNumber
    {
        int getNext(int n)
        {
            int totalsum = 0;
            while(n!=0)
            {
                totalsum += (int)Math.Pow((n % 10) , 2);
                n = n / 10;
            }
            return totalsum;
        }
        public bool IsHappy(int n)
        {
            
            int fastrunner = getNext(n), slowrunner = n;
            while(fastrunner!=1&&slowrunner!=fastrunner)
            {
                slowrunner = getNext(slowrunner);
                fastrunner = getNext(getNext(fastrunner));
            }
            return fastrunner == 1;
        }
    }
}
