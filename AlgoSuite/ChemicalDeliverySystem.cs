using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/893279/
    /// <ID>5013</ID>
    /// </summary>
    class PairInt
    {
        public int first, second;
        public PairInt(int f, int s)
        {
            first = f;
            second = s;
        }
    }
    class SortFlask : IComparer<PairInt>
    {
        public int Compare(PairInt x, PairInt y)
        {
            if (x.first == y.first)
                return x.second.CompareTo(y.second);
            return x.first.CompareTo(y.first);
        }
    }
    class ChemicalDeliverySystem
    {
        
        public int chooseFlask(int numOrders, List<int> requirements,
                              int flaskTypes, int totalMarks, List<PairInt> markingsList)
        {
            int minwaste = int.MaxValue, index = -1;
            int ptr = 0;
            if (numOrders == 0 || totalMarks == 0) return minwaste;
            SortFlask sf = new SortFlask();
            markingsList.Sort(sf);
            while(ptr<markingsList.Count)
            {
                int reqptr = 0;
                int startIndex = markingsList[ptr].first;
                int waste = 0;
                while(ptr<markingsList.Count&& reqptr<requirements.Count&&startIndex==markingsList[ptr].first)
                {
                    if (markingsList[ptr].second < requirements[reqptr])
                    {
                        ptr++;
                        continue;
                    }
                    waste += (markingsList[ptr].second - requirements[reqptr++]);
                }
                while(ptr < markingsList.Count && startIndex == markingsList[ptr].first)
                {
                    ptr++;
                }
                if(reqptr>=requirements.Count&&waste<minwaste)
                {
                    index = startIndex;
                    minwaste = waste;
                }
            }
            return index;
        }
    }
}
