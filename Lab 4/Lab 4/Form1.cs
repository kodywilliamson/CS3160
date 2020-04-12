using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        Game nGame = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTurn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawLine(Pens.Black, 40, 70, 40, 250);
            //e.Graphics.DrawLine(Pens.Black, 40, 250, 220, 250);
            //e.Graphics.DrawLine(Pens.Black, 220, 250, 220, 70);
            //e.Graphics.DrawLine(Pens.Black, 220, 70, 40, 70);
            e.Graphics.DrawLine(Pens.Black, 100, 250, 100, 70);
            e.Graphics.DrawLine(Pens.Black, 160, 250, 160, 70);
            e.Graphics.DrawLine(Pens.Black, 40, 130, 220, 130);
            e.Graphics.DrawLine(Pens.Black, 40, 190, 220, 190);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Point p = Control.MousePosition;
            lblTurn.Text = nGame.nextMove(p.X, p.Y);
        }
    }
}
