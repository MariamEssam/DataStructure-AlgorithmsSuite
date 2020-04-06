using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class Trial
    {
        public List<int> solve(int A, int B, int C, int D)
        {
            List<int> results = new List<int>();
            results.Add(A);
            results.Add(B);
            results.Add(C);
            results.Add(A*B);
            results.Add(A*C);
            results.Add(B*C);
            results.Sort();
            return results.Take(D).ToList();   
        }
    }
}
