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
        public void Debit(decimal amt)
        {
            if (amt < this.balance)
            {
                this.balance -= amt;
                this.balance -= Fee;
            }
            else
            {
                MessageBox.Show("Insufficient Funds");
            }
        }
        public decimal Balance { get { return balance; } }
        public override string ToString()
        {
            return ($"Checking: {this.owner} {this.Balance}");
        }
    }
}
