//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PathSumIII
    {
        int total = 0;
        Dictionary<int, int> SumPaths = new Dictionary<int, int>();
        void findPaths(TreeNode node,int currSum, int target)
        {
            if (node == null)
                return;
            currSum += node.val;
            if (SumPaths.ContainsKey(currSum - target))
                total += SumPaths[currSum - target];
            if (SumPaths.ContainsKey(currSum))
                SumPaths[currSum]++;
            else
                SumPaths.Add(currSum, 1);
            findPaths(node.left, currSum, target);
            findPaths(node.right, currSum, target);
            SumPaths[currSum]--;
            if (SumPaths[currSum] == 0)
                SumPaths.Remove(currSum);
        }
        public int PathSum(TreeNode root, int sum)
        {
            SumPaths.Add(0, 1);
            findPaths(root,0, sum);
            return total;
        }
    }
}
