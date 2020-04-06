using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    
        public class Trie
    {

        Trie[] nodes;
        bool IsWord = false;
        
        /** Initialize your data structure here. */
        public Trie()
        {
            nodes= new Trie[26];
        }

        public void InsertNode(string word,int index)
        {
            
            if( index ==word.Length)
            {
                IsWord = true;
                return;
            }
            if (!Isvalidchar(word[index])) return;
            if(nodes[word[index] - 'a']==null)
               nodes[word[index] - 'a'] = new Trie();
            nodes[word[index] - 'a'].InsertNode(word, ++index);
        }
        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            if (String.IsNullOrEmpty(word)) return;
            InsertNode(word, 0);
        }

        public bool SearchHelper(string word,int index)
        {
            if (index == word.Length)
                return IsWord;

            if (Isvalidchar(word[index]) && nodes[word[index] - 'a']!=null)
            {
                return nodes[word[index] - 'a'].SearchHelper(word, ++index);
            }
            return false;
        }
        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            if (String.IsNullOrEmpty(word)) return false;
            return SearchHelper(word, 0);
        }
        public bool StartsWithHelper(string prefix,int index)
        {
            if (index == prefix.Length) return true;
            if (Isvalidchar(prefix[index]) &&nodes[prefix[index] - 'a']!=null)
            {
                return nodes[prefix[index] - 'a'].StartsWithHelper(prefix, ++index);
            }
            return false;
        }
        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            if (String.IsNullOrEmpty(prefix)) return false;
            return StartsWithHelper(prefix, 0);
        }
        private bool Isvalidchar(char c)
        {
            return (c >= 'a' && c <= 'z');
        }
    }
}
