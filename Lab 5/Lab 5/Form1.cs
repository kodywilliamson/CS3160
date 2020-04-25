using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            if(lstAcc.SelectedItem is SavingsAccount)
            {
                SavingsAccount holder = (SavingsAccount)lstAcc.SelectedItem;
                holder.Credit(holder.CalculateInterest());
            }
            else
            {
                txtMess.Text = "Cannot add interest to CheckingAccount";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InterstellarBank bank = new InterstellarBank();
            bank.AddChecking("Smith", 1000, 1.0M);
            bank.AddSavings("Smith", 23456, 0.03M);
            bank.AddChecking("Jones", 234, 1.0M);
            bank.AddSavings("Jones", 10000, 0.02M);
            bank.AddChecking("Doe", 124, 1.0M);
            bank.Iterator();
            lstAcc.Items.Add(Console.ReadLine());

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal amt = Convert.ToDecimal(txtAmount.Text);
            if (lstAcc.SelectedItem is SavingsAccount)
            {
                SavingsAccount holder = (SavingsAccount)lstAcc.SelectedItem;
                if (cmbTrans.Text == "Credit")
                {
                    holder.Credit(amt);
                }
                else
                {
                    holder.Debit(amt);
                }
            }
            else if (lstAcc.SelectedItem is CheckingAccount)
            {
                CheckingAccount holder = (CheckingAccount)lstAcc.SelectedItem;
                if (cmbTrans.Text == "Credit")
                {
                    holder.Credit(amt);
                }
                else
                {
                    holder.Debit(amt);
                }
            }
        }
    }
}
