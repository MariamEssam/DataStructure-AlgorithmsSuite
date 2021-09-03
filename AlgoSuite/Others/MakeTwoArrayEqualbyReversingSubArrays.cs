using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MakeTwoArrayEqualbyReversingSubArrays
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0;i<target.Length;i++)
            {
                if (!dic.ContainsKey(target[i]))
                    dic.Add(target[i], 0);
                dic[target[i]]++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dic.ContainsKey(arr[i]))
                    return false;
                dic[arr[i]]--;
                if (dic[arr[i]] == 0) dic.Remove(arr[i]);
            }
            return dic.Count == 0;
        }
    }
}
