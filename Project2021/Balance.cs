using System;
using System.Collections.Generic;
using System.Text;

namespace Project2021
{
    class Balance
    {
        private int amount = 0;

        public int Amount
        {
            get { return amount; }
            set { amount += value; }
        }
        public void Payment(int i)
        {
            amount = amount - i;
        }
        public void Refund(int i)
        {
            amount = amount + i;
        }
    }
}
