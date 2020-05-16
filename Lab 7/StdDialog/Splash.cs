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
    public partial class Splash : Form
    {
        public Splash(Image img, string title, string copy, string name, int time)
        {
            InitializeComponent();
            picImg.Image = img;
            lblTitle.Text = title;
            lblCopy.Text = copy;
            lblName.Text = name;
            tmeSplash.Interval = time;
        }

        private void tmeSplash_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
