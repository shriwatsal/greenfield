﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatureapp
{
    public class Account
    {
        public event Operation underBalance;
        public event Operation overBalance;

        public double Balance { get; set; }
        
       public Account(double initialAmount)
        {
            Balance = initialAmount;
        }

        public void Withdraw(double amount)
        {
            double result = Balance - amount;
            if(result<=10000)
            {
                // Raise event Underbalance
                underBalance(5);

            }


            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            if(Balance >=250000) {
                // Raise Event Overbalance
                overBalance(15);

            }
        }
    }
}