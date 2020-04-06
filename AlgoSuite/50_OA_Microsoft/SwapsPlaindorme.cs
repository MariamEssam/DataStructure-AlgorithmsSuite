using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SwapsPlaindorme
    {
        bool IsValidForPlaindorme(string str)
        {
            Dictionary<char, int> dics = new Dictionary<char, int>();
            int oddcount = 0;
            foreach (char c in str)
            {
                if (dics.ContainsKey(c))
                    dics[c]++;
                else
                    dics.Add(c, 1);
            }
            foreach(var v in dics.Values)
            {
                if (v % 2 != 0)
                    oddcount++;
            }
            if (str.Length % 2 != 0 && oddcount == 1) return true;
            if (str.Length % 2 == 0 && oddcount == 0) return true;
            return false;
        }
        public int MinSwaps(string str)
        {
            char[] arr = str.ToCharArray();
            if (!IsValidForPlaindorme(str))
                return -1;
            int cost = 0;
            for(int i=0;i<arr.Length/2;i++)
            {
                bool UniqueCharfound = false;
                for(int j=arr.Length-1;j>i;j--)
                {
                    if(arr[i]==arr[j])
                    {
                        for(int k=j+1;k<str.Length-i;k++)
                        {
                            var ch = arr[k];
                            arr[k] = arr[k - 1];
                            arr[k - 1] = ch;
                            cost++;
                        }
                        UniqueCharfound = true;
                    }
                    
                }
                if (!UniqueCharfound)
                {
                    int Pos = arr.Length / 2;
                    for (int k = Pos + 1; k < str.Length - i; k++)
                    {
                        var ch = arr[k];
                        arr[k] = arr[k - 1];
                        arr[k - 1] = ch;
                        cost++;
                    }
                }
            }
            return cost;
        }
        
    }
}
