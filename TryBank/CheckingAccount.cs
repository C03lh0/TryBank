using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBank
{
    public class CheckingAccount
    {
        public Client holder;
        public int agency;
        public int numberAccount;
        public double balance = 100;

        public bool Withdraw(double value)
        {
            if (this.balance < value)
            {
                return false;
            }

            this.balance -= value;
            return true;
        }

        public void Deposit(double value)
        {
            this.balance += value;
        }

        public bool Transfer(double value, CheckingAccount destinationAccount)
        {
            if (this.balance < value)
            {
                return false;
            }

            this.balance -= value;
            destinationAccount.Deposit(value);
            return true;
        }
    }
}
