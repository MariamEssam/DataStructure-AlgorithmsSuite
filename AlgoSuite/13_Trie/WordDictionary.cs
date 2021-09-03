using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/design-add-and-search-words-data-structure/
    /// <ID>1211</ID>
    /// </summary>
    class TrieNodeWordDictionary
    {
        public Dictionary<Char, TrieNodeWordDictionary> children = new Dictionary<char, TrieNodeWordDictionary>();
        public bool word = false;
        public TrieNodeWordDictionary() { }
    }
    public class WordDictionary
    {
        TrieNodeWordDictionary WordDic;
        /** Initialize your data structure here. */
        public WordDictionary()
        {
            WordDic = new TrieNodeWordDictionary();
        }

        /** Adds a word into the data structure. */
        public void AddWord(string word)
        {
            TrieNodeWordDictionary node = WordDic;
            foreach(char c in word)
            {
                if (!node.children.ContainsKey(c))
                    node.children.Add(c, new TrieNodeWordDictionary());
                 node = node.children[c];

            }
            node.word = true;
        }

        bool SearchWord(string word, TrieNodeWordDictionary node)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (node.children.ContainsKey(word[i]))
                    node = node.children[word[i]];
                else if (word[i] == '.')
                {
                    foreach (char x in node.children.Keys)
                    {
                        TrieNodeWordDictionary child = node.children[x];
                        if (SearchWord(word.Substring(i + 1), child))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else
                    return false;
            }
            return node.word;
        }
        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            return SearchWord(word, WordDic);
        }
    }
}
