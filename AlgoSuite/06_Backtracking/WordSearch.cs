using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class WordSearch
    {
        bool SearchWord(char[][] board,bool[][] visited,int i,int j,string word, int index)
        {
            if (index == word.Length)
                return true;
            bool isfound = false;
            if (i>=0&&i<board.Length&&j>=0&&j<board[0].Length&&visited[i][j]!=true&&word[index]==board[i][j])
            {
                index++;
                visited[i][j] = true;
                if (!isfound)
                    isfound = SearchWord(board, visited, i, j - 1, word, index);
                if(!isfound)
                    isfound = SearchWord(board, visited, i, j + 1, word, index);
                if (!isfound)
                    isfound = SearchWord(board, visited, i - 1, j, word, index);
                if (!isfound)
                    isfound = SearchWord(board, visited, i + 1, j, word, index);

                visited[i][j] = false;
            }
            return isfound;
        }
        public bool Exist(char[][] board, string word)
        {

            bool isfound = false;
            int m = board.Length;
            int n = board[0].Length;
            bool[][] visited = new bool[m][];
            for (int i = 0; i < m; i++)
                visited[i] = new bool[n];
            for(int i=0;i<board.Length;i++)
            {
                for(int j=0;j<board[0].Length;j++)
                {
                    isfound = SearchWord(board, visited, i, j, word, 0);
                    if (isfound)
                        return isfound;
                }
            }
            
            return false;
        }
    }
}
