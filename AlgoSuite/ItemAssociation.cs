using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    public class PairString
    {
        public String first;
        public String second;

        public PairString(String first, String second)
        {
            this.first = first;
            this.second = second;
        }
    }
    class ItemAssociation
    {
        public List<String> largestItemAssociation(List<PairString> itemAssociation)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            for(int i=0;i<itemAssociation.Count;i++)
            {
                if (!dic.ContainsKey(itemAssociation[i].first)) dic.Add(itemAssociation[i].first, new List<string>());
                if (!dic.ContainsKey(itemAssociation[i].second)) dic.Add(itemAssociation[i].second, new List<string>());
                dic[itemAssociation[i].first].Add(itemAssociation[i].second);
                dic[itemAssociation[i].second].Add(itemAssociation[i].first);
            }
            List<string> largest_group = new List<string>();
            HashSet<string> visitedset = new HashSet<string>();
            for(int i=0;i<itemAssociation.Count;i++)
            {
                if(!visitedset.Contains(itemAssociation[i].first))
                {
                    Queue<string> queue = new Queue<string>(dic[itemAssociation[i].first]);
                    List<string> currentlst = new List<string>();
                   while(queue.Count!=0)
                    {
                        string item = queue.Dequeue();
                        if (!visitedset.Contains(item))
                        {
                            visitedset.Add(item);
                            currentlst.Add(item);
                            foreach(string str in dic[item])
                              queue.Enqueue(str);
                        }
                    }
                   if(currentlst.Count>largest_group.Count)
                    {
                        currentlst.Sort();
                        largest_group = currentlst;
                    }
                   else if(currentlst.Count>0&&currentlst.Count==largest_group.Count)
                    {
                        currentlst.Sort();
                        if (largest_group[0].CompareTo(currentlst[0]) > 0)
                            largest_group = currentlst;
                    }

                }
            }
            return largest_group;
        }
    }
}
