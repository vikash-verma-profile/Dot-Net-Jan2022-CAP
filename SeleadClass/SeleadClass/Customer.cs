using System;
using System.Collections.Generic;
using System.Text;

namespace SeleadClass
{
    partial class Customer
    {
        private int amount;
        public int Amount { get; set; }
        public void withdraw(int amount)
        {
            Console.WriteLine("Amount to be withdraw"+amount);
        }
    }
}
