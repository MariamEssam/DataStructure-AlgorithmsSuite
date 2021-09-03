using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/823159/
    /// <ID>5015</ID>
    /// </summary>
    class FetachItemDisplay
    {
       public List<String> fetchItemsToDisplay(int numOfItems, Dictionary<String, Pair> items, int sortParameter, int sortOrder, int itemsPerPage, int pageNumber)
        {
            List<string> result = new List<string>();
            int maxPageNum = (int)Math.Ceiling((double)numOfItems / itemsPerPage);
            if (pageNumber >= maxPageNum)
                return result;
            var sortedlist = items.ToList();
            if (sortParameter == 0 && sortOrder == 0)
                sortedlist.Sort((item1, item2) => item1.Key.CompareTo(item2.Key));
            else if (sortParameter == 0 && sortOrder == 1)
                sortedlist.Sort((item1, item2) => item2.Key.CompareTo(item1.Key));
            else if (sortParameter == 1 && sortOrder == 0)
                sortedlist.Sort((item1, item2) => item1.Value.index.CompareTo(item2.Value.index));
            else if (sortParameter == 1 && sortOrder == 1)
                sortedlist.Sort((item1, item2) => item2.Value.index.CompareTo(item1.Value.index));
            else if (sortParameter == 2 && sortOrder == 0)
                sortedlist.Sort((item1, item2) => item1.Value.val.CompareTo(item2.Value.val));
            else if (sortParameter == 2 && sortOrder == 1)
                sortedlist.Sort((item1, item2) => item2.Value.val.CompareTo(item1.Value.val));
            int startIndex = pageNumber * itemsPerPage;
            int lastIndex = Math.Min(numOfItems, startIndex + itemsPerPage);
            for (int i = startIndex; i < lastIndex; i++)
                result.Add(sortedlist[i].Key);
            return result;
        }
    }
}
