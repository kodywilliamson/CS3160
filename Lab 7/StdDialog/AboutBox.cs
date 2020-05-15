using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdDialog
{
    public partial class AboutBox : Form
    {
        public AboutBox(Image img, string title, string copy, string name)
        {
            InitializeComponent();
            picImg.Image = img;
            lblTitle.Text = title;
            lblCopy.Text = copy;
            lblName.Text = name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {

        }
    }
}
