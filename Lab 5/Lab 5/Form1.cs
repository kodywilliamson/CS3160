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
        InterstellarBank bank;
        public Form1()
        {
            InitializeComponent();
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
            UpdateBox();
            btnInterest.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bank = new InterstellarBank();
            bank.AddChecking("Smith", 1000, 1.0M);
            bank.AddSavings("Smith", 23456, 0.03M);
            bank.AddChecking("Jones", 234, 1.0M);
            bank.AddSavings("Jones", 10000, 0.02M);
            bank.AddChecking("Doe", 124, 1.0M);
            UpdateBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal amt;
            if (!decimal.TryParse(txtAmount.Text, out amt))
            {
                txtMess.Text = "Must input valid number in Amount box";
            }
            else
            {
                if (lstAcc.SelectedItem is SavingsAccount)
                {
                    SavingsAccount holder = (SavingsAccount)lstAcc.SelectedItem;
                    if (cmbTrans.Text == "Credit")
                    {
                        holder.Credit(amt);
                        txtMess.Text = $"{amt} credited to account";
                    }
                    else
                    {
                        if (!holder.Debit(amt))
                        {
                            txtMess.Text = "Insufficient funds, no money debited";
                        }
                        else
                        {
                            txtMess.Text = $"{amt} debited from account";
                        }
                    }
                }
                else if (lstAcc.SelectedItem is CheckingAccount)
                {
                    CheckingAccount holder = (CheckingAccount)lstAcc.SelectedItem;
                    if (cmbTrans.Text == "Credit")
                    {
                        holder.Credit(amt);
                        txtMess.Text = $"{amt} credited to account";
                    }
                    else
                    {
                        if (!holder.Debit(amt))
                        {
                            txtMess.Text = "Insufficient funds, no money debited";
                        }
                        else
                        {
                            txtMess.Text = $"{amt} debited from account";
                        }
                    }
                }
            }
            UpdateBox();
            btnUpdate.Enabled = false;
            cmbTrans.Text = "";
            txtAmount.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateBox()
        {
            btnUpdate.Enabled = false;
            btnInterest.Enabled = false;
            lstAcc.Items.Clear();
            var iter = bank.GetEnumerator();
            while (iter.MoveNext())
            {
                lstAcc.Items.Add(iter.Current);
            }
        }

        private void lstAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnInterest.Enabled = true;
            txtMess.Text = "";
        }
    }
}
