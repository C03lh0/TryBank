using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBank
{
    public class CheckingAccount
    {
        private Client holder;
        private int agency;
        private int numberAccount;
        private double balance = 100;

        public bool Withdraw(double value)
        {
            if (balance < value)
            {
                return false;
            }

            balance -= value;
            return true;
        }

        public void Deposit(double value)
        {
            balance += value;
        }

        public bool Transfer(double value, CheckingAccount destinationAccount)
        {
            if (balance < value)
            {
                return false;
            }

            balance -= value;
            destinationAccount.Deposit(value);
            return true;
        }

        public double GetBalance()
        {
            return balance;  
        }

        public void SetBalance(double value)
        {
            if (value < 0)
            {
                return;
            }
            balance = value;
        }
    }
}
