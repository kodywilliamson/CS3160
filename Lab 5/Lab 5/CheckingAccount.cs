using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    class CheckingAccount : Account, IAccount
    {
        public decimal Fee;
        public CheckingAccount(string name, decimal amt, decimal feeamt)
        {
            this.owner = name;
            this.balance = amt;
            Fee = feeamt;
        }
        public void Credit(decimal amt)
        {
            this.balance += amt;
            this.balance -= Fee;
        }
        public bool Debit(decimal amt)
        {
            if ((amt + Fee) < this.balance)
            {
                this.balance -= amt;
                this.balance -= Fee;
                return true;
            }
            else
            {
                return false;
            }
        }
        public decimal Balance { get { return balance; } }
        public override string ToString()
        {
            return ($"Checking: {this.owner, -37} {this.Balance:C2}");
        }
    }
}
