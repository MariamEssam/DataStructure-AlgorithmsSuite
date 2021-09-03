using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/generate-parentheses/
    /// <ID>1022</ID>
    /// </summary>
    class GenerateParentheses
    {
        IList<string> generatedlst;
        void generate(int n, int parenthesecount, StringBuilder build)
        {
            if (n == 0 && parenthesecount == 0)
            {
                if (build.ToString() != String.Empty)
                    generatedlst.Add(build.ToString());
                return;
            }
            if (n == 0 || parenthesecount != 0)
            {
                build.Append(')');
                generate(n, parenthesecount - 1, build);
                build.Length--;
            }
            if (n != 0)
            {
                build.Append('(');
                generate(n - 1, parenthesecount + 1, build);
                build.Length--;
            }
        }
        public IList<string> GenerateParenthesis(int n)
        {
            generatedlst = new List<string>();
            generate(n, 0, new StringBuilder());
            return generatedlst;
        }
     
    }
}
