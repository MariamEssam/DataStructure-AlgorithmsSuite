using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SmallestNegativeBalance
    {
        public class debtRecord
        {
            public String borrower = "";
            public String lender = "";
            public int amount = 0;
            debtRecord()
            {
                // empty constructor
            }
            public debtRecord(String borrower, String lender, int amount)
            {
                this.borrower = borrower;
                this.lender = lender;
                this.amount = amount;
            }
        }
       public List<String> negativeAccounts(int numRows, int numCols, List<debtRecord> records)
        {
            List<string> result = new List<string>();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int Min = int.MaxValue;
            for(int i=0;i<numRows;i++)
            {
                debtRecord rec = records[i];
                if (!dic.ContainsKey(rec.borrower)) dic.Add(rec.borrower,0);
                if (!dic.ContainsKey(rec.lender)) dic.Add(rec.lender, 0);
                dic[rec.borrower] -= rec.amount;
                dic[rec.lender] += rec.amount;
            }
            foreach (var item in dic)
            {
                Min = Math.Min(Min, item.Value);
            }
            if (records.Count == 0 || Min >= 0)
            {
                result.Add("Nobody has a negative balance");
            }
            else
            {
                foreach (var item in dic)
                {
                    if (item.Value == Min) result.Add(item.Key);
                }
                result.Sort();
            }
            return result;
        }

        }
}
