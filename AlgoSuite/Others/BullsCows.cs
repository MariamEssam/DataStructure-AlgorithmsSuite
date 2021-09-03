using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BullsCows
    {

        public string GetHint(string secret, string guess)
        {
            Dictionary<char, int> h = new Dictionary<char, int>();
            foreach (char s in secret.ToCharArray())
            {
                if (!h.ContainsKey(s))
                    h.Add(s, 0);
                h[s]++;
            }

            int bulls = 0, cows = 0;
            int n = guess.Length;
            for (int idx = 0; idx < n; ++idx)
            {
                char ch = guess[idx];
                if (h.ContainsKey(ch))
                {
                    // corresponding characters match
                    if (ch == secret[idx])
                    {
                        // update the bulls
                        bulls++;
                        // update the cows 
                        // if all ch characters from secret 
                        // were used up
                        if (h[ch] <= 0)
                            cows--;
                        // corresponding characters don't match
                    }
                    else
                    {
                        // update the cows
                        if (h[ch] > 0)
                            cows++;
                    }
                    // ch character was used
                    h[ch]--;
                }
            }

            return bulls.ToString() + "A" + cows.ToString() + "B";
        }

    }
}
