using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class NumbersWithEqualDigitSum
    {
        int getdigitSum(int digit)
        {
            int sum = 0;
            while(digit!=0)
            {
                sum += (digit % 10);
                digit = digit / 10;
            }
            return sum;
        }
        public int MaxEqualdigitsSum(int[] arr)
        {
            int result = -1;
            if (arr.Length == 0)
                return result;
            Dictionary<int, int> dics = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++)
            {
                int digitsum = getdigitSum(arr[i]);
                if(dics.ContainsKey(digitsum))
                {
                    int sum = dics[digitsum] + arr[i];
                    result = result > sum ? result : sum;
                    dics[digitsum] = dics[digitsum] > arr[i] ? dics[digitsum] : arr[i];
                }
                else
                {
                    dics.Add(digitsum, arr[i]);
                }
            }
            return result;
        }
    }
}
