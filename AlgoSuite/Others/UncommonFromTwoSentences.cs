using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class UncommonFromTwoSentences
    {
        void FindUnique(string[] arr,HashSet<string> UniqueWord,HashSet<string> RepeatedWord)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (RepeatedWord.Contains(arr[i])) continue;
                if (UniqueWord.Contains(arr[i]))
                {
                    UniqueWord.Remove(arr[i]);
                    RepeatedWord.Add(arr[i]);
                }
                else
                    UniqueWord.Add(arr[i]);
            }
        }
        public string[] UncommonFromSentences(string A, string B)
        {
            HashSet<string> UniqueWord = new HashSet<string>();
            HashSet<string> RepeatedWord = new HashSet<string>();
            string[] A_str = A.Split(' ');
            string[] B_str = B.Split(' ');
            FindUnique(A_str, UniqueWord, RepeatedWord);
            FindUnique(B_str, UniqueWord, RepeatedWord);
            return UniqueWord.ToArray();
        }
    }
}
