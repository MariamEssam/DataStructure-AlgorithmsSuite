using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/nested-list-weight-sum/
    /// <ID>075</ID>
    /// </summary>

    interface INestedInteger
    {

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // Set this NestedInteger to hold a single integer.
        void SetInteger(int value);

        // Set this NestedInteger to hold a nested list and adds a nested integer to it.
        void Add(NestedInteger ni);

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }
    class NestedInteger:INestedInteger
    {
        // Constructor initializes an empty nested list.
        public NestedInteger() { }

        // Constructor initializes a single integer.
        public NestedInteger(int value) { }

        public void Add(NestedInteger ni)
        {
            throw new NotImplementedException();
        }

        public int GetInteger()
        {
            throw new NotImplementedException();
        }

        public IList<NestedInteger> GetList()
        {
            throw new NotImplementedException();
        }

        public bool IsInteger()
        {
            throw new NotImplementedException();
        }

        public void SetInteger(int value)
        {
            throw new NotImplementedException();
        }
    }
    class NestedListWeightSum
    {
        int DepthSumhelper(IList<NestedInteger> nestedList,int count)
        {
            if (nestedList == null) return 0;
            int sum = 0;
            foreach (var param in nestedList)
            {
                if (param.IsInteger())
                {
                    sum += count * (param.GetInteger());
                }
                else
                {
                    sum+=DepthSumhelper(param.GetList(),count+1);
                }
            }
            return sum;
        }
        public int DepthSum(IList<NestedInteger> nestedList)
        {
            return DepthSumhelper(nestedList, 1);
        }
    }
}
