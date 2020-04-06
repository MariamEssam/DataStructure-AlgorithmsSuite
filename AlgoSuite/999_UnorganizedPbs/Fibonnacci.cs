using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class Fibonnacci
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        public int Fib(int N)
        {
            if (N <= 1) return N;
            if (!dic.ContainsKey(N))
                dic.Add(N, Fib(N - 1) + Fib(N - 2));
            return dic[N];
        }
    }
}
