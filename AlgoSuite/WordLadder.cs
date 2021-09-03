using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/word-ladder/
    /// <ID>1127</ID>
    /// </summary>
    class WordLadder
    {
        /// <summary>
        /// Bidirectional BFS
        /// </summary>
        //public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        //{
        //    int length = 0;

        //    HashSet<string> words = new HashSet<string>(wordList);
        //    HashSet<string> beginSet = new HashSet<string>();
        //    HashSet<string> endSet = new HashSet<string>();

        //    if (!words.Contains(endWord)) return 0;
        //    beginSet.Add(beginWord);
        //    endSet.Add(endWord);

        //    while(beginSet.Count>0&&endSet.Count>0)
        //    {
        //        if(beginSet.Count>endSet.Count)
        //        {
        //            HashSet<string> tempSet = beginSet;
        //            beginSet = endSet;
        //            endSet = tempSet;
        //        }
        //        HashSet<string> newBeginSet = new HashSet<string>();
                
        //    }
        //}
        public int LadderLength_BFS(string beginWord, string endWord, IList<string> wordList)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            bool isFound = false;
            foreach(string str in wordList)
            {
                if (str == endWord) isFound = true;
                StringBuilder build = new StringBuilder(str);
                for(int i=0;i<build.Length;i++)
                {
                    char c = build[i];
                    build[i] = '*';
                    if (!dic.ContainsKey(build.ToString()))
                        dic.Add(build.ToString(), new List<string>());
                    dic[build.ToString()].Add(str);
                    build[i] = c;
                }
            }
            if (!isFound) return 0;
            Queue<KeyValuePair<string, int>> queue = new Queue<KeyValuePair<string, int>>();
            HashSet<string> visited = new HashSet<string>();
            queue.Enqueue(new KeyValuePair<string, int>(beginWord, 1));
            visited.Add(beginWord);
            while(queue.Count!=0)
            {
                var val = queue.Dequeue();
                StringBuilder build = new StringBuilder(val.Key);
                for (int i = 0; i < val.Key.Length; i++)
                {
                    char c = build[i];
                    build[i] = '*';
                    if (dic.ContainsKey(build.ToString()))
                    {
                        foreach (string word in dic[build.ToString()])
                        {
                            if (word == endWord) return val.Value + 1;
                            if (!visited.Contains(word))
                            {
                                visited.Add(word);
                                queue.Enqueue(new KeyValuePair<string, int>(word, val.Value + 1));
                            }
                        }
                    }
                    build[i] = c;
                }
            }
            return 0;
        }
    }
}
