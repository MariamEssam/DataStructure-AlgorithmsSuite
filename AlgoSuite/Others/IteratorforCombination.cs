using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    #region Sol1
    public class CombinationIterator2
    {
        Stack<string> combinationStack;
        public CombinationIterator2(string characters, int combinationLength)
        {
            combinationStack = new Stack<string>();
            int n = characters.Length;
            for(int BitMask = 0; BitMask < 1<<n; BitMask++)
            {
                if(BitCount(BitMask) ==combinationLength)
                {
                    combinationStack.Push(getString(characters, BitMask));
                }
            }
        }
        private string getString(string str,int bitmask)
        {
            StringBuilder build = new StringBuilder();
            for(int i=0;i<str.Length;i++)
            {
                if ((bitmask & (1 << (str.Length - i - 1))) != 0) build.Append(str[i]);
            }
            return build.ToString();
        }
        private int BitCount(int val)
        {
            int count = 0;
            while(val!=0)
            {
                if ((val & 1) != 0) count++;
                val = val >> 1;
            }
            return count;
        }
        public string Next()
        {
            return combinationStack.Pop();
        }

        public bool HasNext()
        {
            return combinationStack.Count != 0 ? true : false;
        }
    }
    #endregion
    public class CombinationIterator
    {
        int BitMask, length, k;
        string chars;
        public CombinationIterator(string characters, int combinationLength)
        {
            length = characters.Length;
            BitMask = 1 << length;
            k = combinationLength;
            BitMask = getNextBitMask(BitMask);
            chars = characters;
        }

        public string Next()
        {
            string str = getString(chars, BitMask);
            BitMask= getNextBitMask(BitMask);
            return str;
        }
        int getNextBitMask(int bitMask)
        {
            do
            {
                bitMask--;
            } while (bitMask > 0 && BitCount(bitMask) != k);
            return bitMask;
        }
        public bool HasNext()
        {
            return BitMask > 0 ? true : false;
        }
        private string getString(string str, int bitmask)
        {
            StringBuilder build = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if ((bitmask & (1 << (str.Length - i - 1))) != 0) build.Append(str[i]);
            }
            return build.ToString();
        }
        private int BitCount(int val)
        {
            int count = 0;
            while (val != 0)
            {
                if ((val & 1) != 0) count++;
                val = val >> 1;
            }
            return count;
        }
    }

    /**
     * Your CombinationIterator object will be instantiated and called as such:
     * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
     * string param_1 = obj.Next();
     * bool param_2 = obj.HasNext();
     */
}
