using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ProductOfNumbers
    {
        List<int> numslist;
        int product = 0;
        public ProductOfNumbers()
        {
            numslist = new List<int>();
            Add(0);
        }

        public void Add(int num)
        {
            if(num==0)
            {
                numslist.Clear();
                numslist.Add(1);
            }
            else
            {
                numslist.Add(num * numslist[numslist.Count - 1]);
            }
        }

        public int GetProduct(int k)
        {
            int size = numslist.Count;
            return k < size  ? numslist[size - 1] / numslist[size - k - 1] : 0;
        }
    }
}
