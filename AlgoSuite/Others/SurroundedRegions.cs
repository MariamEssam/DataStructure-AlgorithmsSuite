using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SurroundedRegions
    {
        void findconnectedelements(char[][] board,int[][] visited,int i,int j)
        {
            if(i>=0&&i<board.Length&&j>=0&&j<board[0].Length&&visited[i][j]==0&&board[i][j]== 'O')
            {
                visited[i][j] = 1;
                findconnectedelements(board, visited, i - 1, j);
                findconnectedelements(board, visited, i + 1, j);
                findconnectedelements(board, visited, i, j-1);
                findconnectedelements(board, visited, i, j+1);
            }
            
        }
        public void Solve(char[][] board)
        {
            int n = board.Length, m = board[0].Length;
            int[][] visited = new int[n][];
            for (int i = 0; i < m; i++)
                visited[i] = new int[m];
            for(int i=0;i<n;i++)
            {
                if(visited[i][0]==0&&board[i][0]=='O')
                  findconnectedelements(board, visited,i,0);
                if (visited[i][m-1] == 0 && board[i][m-1] == 'O')
                    findconnectedelements(board, visited, i, m-1);
            }
            for (int j = 0; j < m; j++)
            {
                if (visited[0][j] == 0 && board[0][j] == 'O')
                    findconnectedelements(board, visited, 0, j);
                if (visited[n-1][j] == 0 && board[n-1][j] == 'O')
                    findconnectedelements(board, visited, n-1, j);
            }
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    if(visited[i][j]!=1)
                    {
                        board[i][j] = 'X';
                    }
                }
            }
        }
    }
}
