using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstEvents.Items.RemoveAt(lstEvents.SelectedIndex);
            btnDelete.Enabled = false;
            txtDetail.Text = "";
            txtDate.Text = "";
            txtDay.Text = "";
            txtTime.Text = "";
        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            Event displayer = (Event)lstEvents.SelectedItem;
            txtDetail.Text = displayer.eventTitle;
            txtDate.Text = displayer.startTime.ToShortDateString();
            txtDay.Text = $"{displayer.startTime.DayOfWeek}";
            txtTime.Text = $"{displayer.startTime.TimeOfDay} to {displayer.endTime.TimeOfDay}";
        }
    }
}
