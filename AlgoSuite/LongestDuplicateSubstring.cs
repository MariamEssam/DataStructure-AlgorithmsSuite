using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LongestDuplicateSubstring
    {
        int Search(int L, int a, long modulus, int n, int[] nums)
        {
            long h = 0;
            for (int i = 0; i < L; i++) h = (h * a + nums[i]) % modulus;
            HashSet<long> seen = new HashSet<long>();
            seen.Add(h);
            long aL = 1;
            for (int i = 1; i <= L; ++i) aL = (aL * a) % modulus;
            for (int start = 1; start < n - L + 1; ++start)
            {
                // compute rolling hash in O(1) time
                h = (h * a - nums[start - 1] * aL % modulus + modulus) % modulus;
                h = (h + nums[start + L - 1]) % modulus;
                if (seen.Contains(h)) return start;
                seen.Add(h);
            }
            return -1;

        }
        public string LongestDupSubstring(string S)
        {
            int n = S.Length;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = S[i] - 'a';
            int a = 26;
            long modulus = (long)Math.Pow(2, 32);
            int l = 1, r = n;
            while(l<=r)
            {
                int mid = l + (r - l) / 2;
                if (Search(mid, a, modulus, n, arr) != -1) l = mid + 1;
                else r = mid - 1;
            }
            int start = Search(l - 1, a, modulus, n, arr);
            return S.Substring(start, start + l - 1);
        }
    }
}
