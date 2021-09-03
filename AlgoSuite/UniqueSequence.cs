using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://aonecode.com/amazon-online-assessment-winning-sequence
    /// <ID>5012</ID>
    /// </summary>
    class UniqueSequence
    {
        public int[] generateSequence(int num, int lower, int upper)
        {
            if (num == 0 || (upper - lower) * 2 + 1 < num) return new int[0];
            int[] result = new int[num];
            int peek = Math.Min(num - 1, upper - lower + 1);
            int mid = num - peek;
            result[mid] = upper;
            int val = upper;
            for(int i=mid-1;i>=0;i--)
            {
                val--;
                result[i] = val;
            }
            val = upper;
            for (int i = mid + 1; i<num; i++)
            {
                val--;
                result[i] = val;
            }
            return result;
        }
    }
}
