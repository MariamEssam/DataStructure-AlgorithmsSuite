using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FloodFillC
    {
        void helper(int[][] image,int i,int j,int newcolor,int val,bool[][] visited)
        {
            if (i<0||i>=image.Length||j<0||j>=image[0].Length|| visited[i][j] == true)
                return;
            visited[i][j] = true;
            image[i][j] = newcolor;
            helper(image, i, j - 1, newcolor,val,visited);
            helper(image, i, j + 1, newcolor,val,visited);
            helper(image, i - 1,j, newcolor,val,visited);
            helper(image, i + 1,j, newcolor,val,visited);

        }
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image.Length == 0)
                return image;
            bool[][] visited = new bool[image.Length][];
            for (int i = 0; i < image.Length; i++)
                visited[i] = new bool[image[0].Length];
            helper(image, sr, sc, newColor,image[sr][sc],visited);
            return image;
        }
    }
}
