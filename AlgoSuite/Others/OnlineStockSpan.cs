using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    public class StockSpannerElement
    {
        public int price = 0;
        public int weight = 1;
        public StockSpannerElement(int _p)
        {
            price = _p;
        }
    }
    public class StockSpanner
    {
        Stack<StockSpannerElement> stockStack;
        public StockSpanner()
        {
            stockStack = new Stack<StockSpannerElement>();
        }

        public int Next(int price)
        {
            StockSpannerElement element = new StockSpannerElement(price); 
            while(stockStack.Count!=0&&stockStack.Peek().price<=element.price)
            {
                element.weight +=stockStack.Pop().weight;
            }
            stockStack.Push(element);
            return element.weight;
        }
    }
}
