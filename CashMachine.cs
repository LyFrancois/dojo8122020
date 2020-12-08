using System;
using System.Collections.Generic;
using System.Text;


namespace DojoTDDATM
{
    public class CashMachine
    {

        public Dictionary<Int32, Int32> RemainingCash { get; set; }
         = new Dictionary<Int32, Int32> {
         {500, 0}, {200, 0}, {100, 0}, {50, 0}, {20, 0}, {10, 0}, {5, 0} };

        public void AddCash(int v1, int v2)
        {
            if (v2 < 0)
            {
                throw new ArgumentException();
            }
            RemainingCash[v1] = v2 + RemainingCash[v1];
        }
        public Dictionary<Int32, Int32> Withdraw(int v)
        {
            Dictionary<Int32, Int32> money = new Dictionary<Int32, Int32>();
            List<Int32> bills = new List<Int32> {
                500, 200, 100, 50,20, 5 };
            foreach (var i in bills)
            {
                if (v >= i)
                {
                    RemainingCash[i] = RemainingCash[i] - 1;
                    if (money.ContainsKey(i))
                    {
                        money[i] = money[i] + 1;

                    }
                    else
                    {
                        money[i] = 1;
                    }
                    v = v - i;
                }
            }
            return money;
        }
    }
}