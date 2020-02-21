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
        private decimal formCharge;
        
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
            private int Item;
            private int Size;
            private int Quantity;
            private static decimal[,] itemCost;
            private static string format;

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

            }
        }
    }
}
