using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FruitIntoBaskets
    {
        public int TotalFruit(int[] tree)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int ptr1 = 0, ptr2 = 0;
            int max = 0, total = 0;
            while (ptr1 < tree.Length && ptr2 < tree.Length)
            {
                if (dic.ContainsKey(tree[ptr2]))
                {
                    total = ptr2 - ptr1 + 1;
                    max = Math.Max(max, total);
                    dic[tree[ptr2]]++;
                    ptr2++;
                }
                else
                {
                    if (dic.Count >= 2)
                    {
                        dic[tree[ptr1]]--;
                        if (dic[tree[ptr1]] == 0)
                        {
                            dic.Remove(tree[ptr1]);
                        }
                        ptr1++;
                    }
                    else
                    {
                        dic.Add(tree[ptr2], 1);
                        ptr2++;
                    }
                }
            }
            return max;
        }
    }
}
