using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BinaryTreeVerticalTraversal
    {
        void ExpandNode(TreeNode node,SortedDictionary<int, SortedDictionary<int, List<int>>> dic,int x,int y)
        {
            if(node!=null)
            {
                if (!dic.ContainsKey(x))
                    dic.Add(x, new SortedDictionary<int, List<int>>());
                if (!dic[x].ContainsKey(y))
                    dic[x].Add(y, new List<int>());
                dic[x][y].Add(node.val);
                ExpandNode(node.left, dic, x - 1, y + 1);
                ExpandNode(node.right, dic, x + 1, y + 1);
            }
        }
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            SortedDictionary<int, SortedDictionary<int, List<int>>> dic = new SortedDictionary<int, SortedDictionary<int, List<int>>>();
            ExpandNode(root, dic, 0, 0);
            foreach(var x in dic)
            {
                result.Add(new List<int>());
                foreach(var y in x.Value)
                {
                    y.Value.Sort();
                    for (int i = 0; i < y.Value.Count; i++)
                        result[result.Count - 1].Add(y.Value[i]);
                }
            }
            return result;
        }
    }
}
