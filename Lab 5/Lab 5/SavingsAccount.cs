using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    class SavingsAccount : Account, IAccount
    {
        public decimal interestRate;
        public SavingsAccount(string name, decimal amt, decimal interest)
        {
            this.owner = name;
            interestRate = interest;
            this.balance = amt;
        }
        public void Credit(decimal amt)
        {
            this.balance += amt;
        }
        public void Debit(decimal amt)
        {
            if (amt < this.balance)
            {
                this.balance -= amt;
            }
            else
            {
                MessageBox.Show("Insufficient Funds");
            }
        }
        public decimal Balance { get { return balance; } }
        public override string ToString()
        {
            return ($"Savings: {this.owner, -37} {this.Balance:C2}");
        }
        public decimal CalculateInterest()
        {
            decimal dailyint = interestRate / 360;

            return dailyint * balance;
        }
    }
}
