using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LetterCombinationsofaPhoneNumber
    {
        List<string> foundlist;
        Dictionary<char, string> dics = new Dictionary<char, string>
        {
            {'2',"abc" },
            {'3',"def" },
            {'4',"ghi" },
            {'5',"jkl" },
            {'6',"mno" },
            {'7',"pqrs" },
            {'8',"tuv" },
            {'9',"wxyz" }
        };

        void Compositon(int index,string digits,string composedstr)
        {
            if(index>=digits.Length)
            {
                foundlist.Add(composedstr);
                return;
            }
            string found = "";
            if(dics.ContainsKey(digits[index]))
               found=dics[digits[index]];
            index++;
            foreach(var c in found)
            {
                Compositon(index, digits, composedstr + c);
            }
        }
        public IList<string> LetterCombinations(string digits)
        {
            if (String.IsNullOrEmpty(digits))
                return foundlist;
            foundlist = new List<string>();
            Compositon(0, digits, "");
            return foundlist;
        }
    }
}
