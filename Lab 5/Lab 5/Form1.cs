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
            if(lstAcc.SelectedItem != SavingsAccount)
            SavingsAccount addint = (SavingsAccount)lstAcc.SelectedItem;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InterstellarBank bank = new InterstellarBank();
            bank.AddChecking("Smith", 1000, 1.0M);
            bank.AddSavings("Smith", 23456, 0.03M);
            bank.AddChecking("Jones", 234, 1.0M);
            bank.AddSavings("Jones", 10000, 0.02M);
            bank.AddChecking("Doe", 124, 1.0M);
        }
    }
}
