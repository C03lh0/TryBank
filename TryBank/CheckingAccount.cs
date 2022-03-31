using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBank
{
    public class CheckingAccount
    {
        public Client Holder {get; set; }

        private int agency;
        private int numberAccount;
        private double _balance = 100;


        public double Balance 
        {
            get
            {
                return _balance; 
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _balance = value;
            }
        }

        public bool Withdraw(double value)
        {
            if (_balance < value)
            {
                return false;
            }

            _balance -= value;
            return true;
        }

        public void Deposit(double value)
        {
            _balance += value;
        }

        public bool Transfer(double value, CheckingAccount destinationAccount)
        {
            if (_balance < value)
            {
                return false;
            }

            _balance -= value;
            destinationAccount.Deposit(value);
            return true;
        }
    }
}
