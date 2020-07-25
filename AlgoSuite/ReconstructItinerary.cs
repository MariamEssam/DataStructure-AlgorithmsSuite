using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ReconstructItinerary
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            for(int i=0;i<tickets.Count;i++)
            {
                if (dic.ContainsKey(tickets[i][0]))
                {
                    dic[tickets[i][0]].Add(tickets[i][1]);
                    dic[tickets[i][0]].Sort();
                }
                else
                    dic.Add(tickets[i][0],new List<string>() { tickets[i][1] });
            }
            IList<string> res = new List<string>();
            string nextdest = "JFK";
            res.Add(nextdest);
            while(dic.ContainsKey(nextdest))
            {
                string l_nextdest = dic[nextdest][0];
                dic[nextdest].RemoveAt(0);
                if (dic[nextdest].Count == 0)
                    dic.Remove(nextdest);
                res.Add(l_nextdest);
                nextdest = l_nextdest;
            }
            return res;
        }
    }
}
