using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        private int formItem;
        private int formSize;
        private decimal formCharge = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public class PurchasedItem
        {
            private string[] itemStr = { "Sandwich", "Fries", "Soft Drink", "Water" };
            private string[] itemSize = { "Small", "Medium", "Large" };
            private int Item;
            private int Size;
            private int Quantity;
            private static decimal[,] itemCost;
            private static string format;

            public PurchasedItem(int i, int s, int q)
            {
                Item = i;
                Size = s;
                Quantity = q;
            }
            static PurchasedItem()
            {
                format = "{0,2} {1,1} {2,-15} {3,10:C}";
                itemCost = new decimal[4, 3]
                {
                     {2.50M, 3.00M, 3.50M},
                     {0.99M, 1.29M, 1.49M},
                     {1.29M, 1.40M, 1.60M},
                     {0.00M, 0.00M, 0.00M}
                };
            }
            public decimal Cost
            {
                get { return (itemCost[Item, Size] * Quantity); }
            }
            public override string ToString()
            {
                return String.Format($"{Quantity.ToString()} {Size} {Item} {Cost}", format);
            }
        }
        private void radWater_CheckedChanged(object sender, EventArgs e)
        {
            radSmall.Enabled = true;
            radMedium.Enabled = false;
            radLarge.Enabled = false;
            radSmall.Checked = true;
            cmbQuant.Enabled = true;
            btnOrder.Enabled = true;
            formItem = 3;
            formSize = 0;
            this.cmbQuant.SelectedIndex = 0;
        }
        private void enableSizes()
        {
            radSmall.Enabled = true;
            radMedium.Enabled = true;
            radLarge.Enabled = true;
            radSmall.Checked = false;
            radMedium.Checked = false;
            radLarge.Checked = false;
        }

        private void radSandwich_CheckedChanged(object sender, EventArgs e)
        {
            enableSizes();
            cmbQuant.Enabled = false;
            btnOrder.Enabled = false;
            formItem = 0;
        }

        private void radFries_CheckedChanged(object sender, EventArgs e)
        {
            enableSizes();
            cmbQuant.Enabled = false;
            btnOrder.Enabled = false;
            formItem = 1;
        }

        private void radSoft_CheckedChanged(object sender, EventArgs e)
        {
            enableSizes();
            cmbQuant.Enabled = false;
            btnOrder.Enabled = false;
            formItem = 2;
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            formSize = 0;
            cmbQuant.Enabled = true;
            btnOrder.Enabled = true;
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            formSize = 1;
            cmbQuant.Enabled = true;
            btnOrder.Enabled = true;
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            formSize = 2;
            cmbQuant.Enabled = true;
            btnOrder.Enabled = true;
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            PurchasedItem order = new PurchasedItem(formItem, formSize, cmbQuant.SelectedIndex);
            formCharge += order.Cost;
            lblTotal.Text = formCharge.ToString("C");
            lstOrder.Items.Add(order.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
