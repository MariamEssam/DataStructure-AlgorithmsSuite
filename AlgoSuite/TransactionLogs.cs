using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class TransactionLogs
    {
        public List<String> getFraudIds(String[] input, int threshold)
        {
            SortedDictionary<string, int> dic = new SortedDictionary<string, int>();
            List<string> res = new List<string>();
            for(int i=0;i<input.Length;i++)
            {
                string[] log = input[i].Split(null);
                if (!dic.ContainsKey(log[0])) dic.Add(log[0], 0);
                if (!dic.ContainsKey(log[1])) dic.Add(log[1], 0);
                dic[log[0]]++;
                if (log[0] != log[1]) dic[log[1]]++;
            }
            foreach(var item in dic)
            {
                if (item.Value >= threshold)
                    res.Add(item.Key);
            }
            res.Sort();
            return res;
        }
    }
}
