using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LoggerRateLimiter
    {
        public class Message
        {
            public int timestamp;
            public string message;
            public Message(int t,string m)
            {
                timestamp = t;
                message = m;
            }
        }
        public class Logger
        {
            Queue<Message> msgqueue = new Queue<Message>();
            HashSet<string> msgset = new HashSet<string>();
            /** Initialize your data structure here. */
            public Logger()
            {

            }

            void UpdateQueue(int timestamp,string message)
            {
                while(msgqueue.Count!=0&&timestamp- msgqueue.Peek().timestamp>=10)
                {
                    Message msg = msgqueue.Dequeue();
                    msgset.Remove(msg.message);
                }
            }

            /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
                If this method returns false, the message will not be printed.
                The timestamp is in seconds granularity. */
            public bool ShouldPrintMessage(int timestamp, string message)
            {
                UpdateQueue(timestamp,message);
                if (!msgset.Contains(message))
                {
                    msgqueue.Enqueue(new Message(timestamp, message));
                    msgset.Add(message);
                    return true;
                }
                return false;
            }
        }
    }
}
