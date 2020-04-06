using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class NumUniqueEmailsC
    {
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> emailsdic = new HashSet<string>();
            foreach(string str in emails)
            {
                string[] splitted = str.Split(new char[] { '@' });
                if (splitted.Length < 2) return 0;
                String half = splitted[0].Replace(".","");
                String[] halfsplitted = half.Split(new char[] { '+' });
                if (!emailsdic.Contains(halfsplitted[0] +"@"+splitted[2])) emailsdic.Add(halfsplitted[0] + "@" + splitted[2]);
            }
            return emailsdic.Count;
        }
    }
}
