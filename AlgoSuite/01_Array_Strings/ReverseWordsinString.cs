using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// <tag>Array&String</tag>
    /// <ID></ID>
    /// <code></code>
    /// <Link></Link>
    /// </summary>
    class ReverseString
    {
        public string ReverseWordsinString(string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;
            string[] splitted_s = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(splitted_s);
            return String.Join(" ", splitted_s);
        }
        public string ReverseWords2(string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;
            int i = s.Length;
            string str = "";
            string str_p = "";
            while (i >= 0)
            {
                if (s[i] == ' ' || i == 0)
                {
                    str_p += s[i];
                    if (str_p != " ")
                        str += str_p;
                    str_p = "";
                }
                else
                    str_p = s[i] + str_p;
                i--;
            }
            return str;
        }
    }
}
