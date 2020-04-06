using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SerializeDeserializeTree
    {
        public class Codec
        {
            public void serializehelper(StringBuilder build, TreeNode node)
                {
                if (node == null) return;
                serializehelper(build, node.left);
                serializehelper(build, node.right);
                build.Append(node.val + " ");
            }
            // Encodes a tree to a single string.
            public string serialize(TreeNode root)
            {
                StringBuilder build = new StringBuilder();
                serializehelper(build, root);
                return build.ToString();
            }
            TreeNode deserializehelper(List<string> nodes_str,int lower,int upper)
            {
                if (nodes_str.Count == 0) return null;
                int val = int.Parse(nodes_str[nodes_str.Count-1]);
                if(val>lower&&val<upper)
                {
                    nodes_str.RemoveAt(nodes_str.Count - 1);
                    TreeNode node = new TreeNode(val);
                    node.right = deserializehelper(nodes_str, val, upper);
                    node.left = deserializehelper(nodes_str, lower, val);
                    return node;
                }
                return null;
            }
            // Decodes your encoded data to tree.
            public TreeNode deserialize(string data)
            {
               if (String.IsNullOrEmpty(data)) return null;
               List<string> nodes_str = data.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                return deserializehelper(nodes_str, int.MaxValue, int.MinValue);
            }
        }
    }
}
