using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBank
{
    public class CheckingAccount
    {
        public Client Holder { get; set; }
        public int NumberAccount { get; set; }
        //Essa propriedade static é própria da classe e não do objeto. Ou seja todos os objetos compartilham da mesma propriedade.
        public static int TotalDeContasCriadas { get; private set; }    

        public int _agency;
        public int Agency 
        {
            get
            {
                return _agency; 
            }
            set
            {
                if(value < 0)
                {
                    return;
                } 
                _agency = value;
            } 
        }

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

        public CheckingAccount(int numberAccount, int agency)
        {
            NumberAccount = numberAccount;
            Agency = agency;
            TotalDeContasCriadas++;
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
