using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class TrieNode
    {
        public Dictionary<char, TrieNode> Next = new Dictionary<char, TrieNode>();
        public string word = null;
        public char ch;
        public TrieNode()
        {

        }
        public TrieNode(char c)
        {
            this.ch = c;
        }
    }
    class WordSearchII
    {
        #region NonOptimalSolution
        //HashSet<string> findingdics = new HashSet<string>();
        //HashSet<string> serachinglist = new HashSet<string>();
        //Dictionary<char,int[]> chardics = new Dictionary<char, int[]>();
        //List<string> ValidateList(int index,List<string> oldlist,int c)
        //{
        //    List<string> newwordlist = new List<string>();
        //    foreach(var v in oldlist)
        //    {
        //        if (v.Length > index && (v[index] == c||index==-1)) newwordlist.Add(v); 
        //    }
        //    return newwordlist;
        //}
        //void SearchWord2(char[][] board, bool[][] visited, int i, int j, string word,int index,List<string> wordsValidlist)
        //{
        //    if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length)
        //        return;

        //    List<string> newvalidlist = ValidateList(index, wordsValidlist, board[i][j]);
        //    if(visited[i][j]!=true&&newvalidlist.Count>0)
        //    {
        //        visited[i][j] = true;
        //        index++;
        //        word += board[i][j];
        //        if (serachinglist.Contains(word) && !findingdics.Contains(word))
        //            findingdics.Add(word);
        //        if(findingdics.Count!=serachinglist.Count)
        //        SearchWord2(board, visited, i + 1, j, word,index,newvalidlist);
        //        if (findingdics.Count != serachinglist.Count)
        //            SearchWord2(board, visited, i - 1, j, word,index, newvalidlist);
        //        if (findingdics.Count != serachinglist.Count)
        //            SearchWord2(board, visited, i , j + 1, word, index, newvalidlist);
        //        if (findingdics.Count != serachinglist.Count)
        //            SearchWord2(board, visited, i , j - 1, word, index, newvalidlist);

        //        visited[i][j] = false;
        //    }
        //}
        //public IList<string> FindWords(char[][] board, string[] words)
        //{
        //    int m = board.Length;
        //    int n = board[0].Length;
        //    bool[][] visited = new bool[m][];
        //    for (int i = 0; i < m; i++)
        //        visited[i] = new bool[n];
        //    foreach (var v in words)
        //        serachinglist.Add(v);
        //    for (int i = 0; i < board.Length; i++)
        //    {
        //        for (int j = 0; j < board[0].Length; j++)
        //        {
        //            List<string> valid = ValidateList(-1, words.ToList(), ' ');
        //            SearchWord2(board, visited, i, j, "",0,valid);
        //        }
        //    }
        //    return findingdics.ToList();
        //}
        #endregion
        HashSet<string> findinglist;
        char[][] board_gen;
        TrieNode ComposeTrie(string[] words)
        {
            TrieNode root = new TrieNode();
            foreach(var word in words)
            {
                TrieNode Node = root;
                foreach(var c in word)
                {
                    if (!Node.Next.ContainsKey(c))
                    {
                        Node.Next.Add(c, new TrieNode(c));
                    }
                    Node = Node.Next[c];
                }
                Node.word = word;
            }
            return root;
        }
        void search(TrieNode node,int i,int j)
        {
            char letter = board_gen[i][j];
            if (node.Next.ContainsKey(letter))
            {
                node = node.Next[letter];
                if (node.word != null && !findinglist.Contains(node.word))
                    findinglist.Add(node.word);
                int[] dir_i = new int[] { 0, 1, 0, -1 };
                int[] dir_j = new int[] { 1, 0, -1,0 };
                board_gen[i][j] = '#';
                for (int k=0;k<4;k++)
                {
                    int new_i = i + dir_i[k];
                    int new_j = j + dir_j[k];
                    if(new_i>=0&&new_i<board_gen.Length&&new_j>=0&&new_j<board_gen[0].Length)
                    {
                        search(node, new_i, new_j);
                    }
                }
                board_gen[i][j] = letter;

            }

        }
        public IList<string> FindWords(char[][] board, string[] words)
        {
            findinglist = new HashSet<string>();
            if (board.Length == 0 || words.Length == 0)
                return findinglist.ToList();
            board_gen = board;
            TrieNode Tree = ComposeTrie(words);
            for(int i=0;i<board.Length;i++)
            {
                for(int j=0;j<board[0].Length;j++)
                {
                    search(Tree, i, j);
                }
            }
            return findinglist.ToList();
        }
    }
}
