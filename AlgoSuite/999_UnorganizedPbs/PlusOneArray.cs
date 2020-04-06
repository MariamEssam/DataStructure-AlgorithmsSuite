using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PlusOneArray
    {
        public List<int> plusOne(List<int> A)
        {
            int i = 0;
            int carryon = 0;
            do
            {
                if (i < A.Count)
                {
                    int val = A[A.Count - i - 1];
                    A[A.Count - i - 1] = val % 10;
                    carryon = val / 10;
                }
                else
                {
                    A.Insert(0, carryon);
                    carryon = 0;
                }
                i++;
            } while (carryon != 0);
            for(int k=0;k<=i;k++)
            {
                if (A[k] == 0)
                {
                    A.RemoveAt(k);
                    k--;
                    i--;
                }
                else
                    break;
            }
            return A;
        }
    }
}
