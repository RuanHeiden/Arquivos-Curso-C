using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoadLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loadlimit) : base(number, holder, balance)
        {

            LoadLimit = loadlimit;

        }

        public void Load(double amount)
        {
            if (amount  <= LoadLimit) {
                Balance += amount;
            }
        }


    }
}
