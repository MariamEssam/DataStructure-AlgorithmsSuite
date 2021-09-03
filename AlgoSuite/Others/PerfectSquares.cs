using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PerfectSquares
    {
        
        public int NumSquares(int n)
        {
            int[] dic = new int[n + 1];
            for (int i = 1; i <= n; i++)
                dic[i] = int.MaxValue;
            dic[0] = 0;
            // pre-calculate the square numbers.
            int max_square_index = (int)Math.Sqrt(n) + 1;
            int[] square_nums = new int[max_square_index];
            for (int i = 1; i < max_square_index; ++i)
            {
                square_nums[i] = i * i;
            }

            for (int i = 1; i <= n; ++i)
            {
                for (int s = 1; s < max_square_index; ++s)
                {
                    if (i < square_nums[s])
                        break;
                    dic[i] = Math.Min(dic[i], dic[i - square_nums[s]] + 1);
                }
            }
            return dic[n];
        }
    }
}
