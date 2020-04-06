using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ReverseVowelsString
    {
        
        public string ReverseVowels(string s)
        {
            int l = 0, r = s.Length - 1;
            char[] arr = s.ToCharArray();
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'o', 'i', 'u' };
            while(l<r)
            {
                if(!vowels.Contains(Char.ToLower(arr[l])))
                {
                    l++;
                    continue;
                }
                if (!vowels.Contains(Char.ToLower(arr[r])))
                {
                    r--;
                    continue;
                }
                char temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                l++;
                r--;
            }
            return new string(arr);
    }
    }
}
