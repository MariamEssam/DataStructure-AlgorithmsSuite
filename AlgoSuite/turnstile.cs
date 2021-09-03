using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/853053/
    /// <ID>5010</ID>
    /// </summary>
    class turnstile
    {
        public int[] run(int n, int[] times, int[] directions)
        {
            int[] result = new int[n];
            Queue<Tuple<int, int>> entryQueue = new Queue<Tuple<int, int>>();
            Queue<Tuple<int, int>> exitQueue = new Queue<Tuple<int, int>>();
            int lastEntry = -1, lastExit = -1;
            int ptr = 0;
            while(ptr<n||entryQueue.Count!=0||exitQueue.Count!=0)
            {
                int lasttime = Math.Max(lastEntry, lastExit);
                if(ptr<n)
                {
                    do
                    {
                        if(directions[ptr]==1)
                        {
                            exitQueue.Enqueue(new Tuple<int, int>(times[ptr], ptr));
                        }
                        else
                            entryQueue.Enqueue(new Tuple<int, int>(times[ptr], ptr));
                        ptr++;
                    } while (ptr < n && times[ptr - 1] == times[ptr]);
                }

                if(exitQueue.Count==0||(entryQueue.Count!=0&&lasttime!=-1&&((lastEntry!=-1&&(entryQueue.Peek().Item1-lastEntry)<=1)||(exitQueue.Peek().Item1-entryQueue.Peek().Item1>1))))
                {
                    var cust = entryQueue.Dequeue();
                    result[cust.Item2] = Math.Max(lasttime + 1, cust.Item1);
                    lastEntry = result[cust.Item2];
                }
                else
                {
                    var cust = exitQueue.Dequeue();
                    result[cust.Item2] = Math.Max(lasttime + 1, cust.Item1);
                    lastExit = result[cust.Item2];
                }
            }
            return result;

        }
    }
    }
