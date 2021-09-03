using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class GoatLatin
    {
        public string ToGoatLatin(string S)
        {
            StringBuilder builder = new StringBuilder();
            string[] splitted_str = S.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splitted_str.Length; i++)
            {
                if (i != 0)
                    builder.Append(" ");
                StringBuilder word = new StringBuilder(splitted_str[i]);
                if (!IsVowel(word[0]))
                {
                    char c = word[0];
                    word.Remove(0, 1);
                    word.Append(c);
                }
                word.Append("ma");
                Appenda(word, i + 1);
                builder.Append(word);
            }
            return builder.ToString();
        }
        bool IsVowel(char c)
        {
            c = Char.ToLower(c);
            return c == 'a' || c == 'o' || c == 'i' || c == 'e' || c == 'u';
        }
        void Appenda(StringBuilder builder,int count)
        {
            while(count!=0)
            {
                count--;
                builder.Append("a");
            }
        }
    }
}
