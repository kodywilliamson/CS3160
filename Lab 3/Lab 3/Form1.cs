﻿using System;
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
        string[] value = new string[8];
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                form2.Enabled=true;
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    value[0] = form2.Year;
                    value[1] = form2.Month;
                    value[2] = form2.Day;
                    value[3] = form2.StHour;
                    value[4] = form2.StMin;
                    value[5] = form2.EndHour;
                    value[6] = form2.EndMin;
                    value[7] = form2.Desc;

                }
            }
            Event appt = new Event(Int32.Parse(value[0]), Int32.Parse(value[1]), Int32.Parse(value[2]), Int32.Parse(value[3]), Int32.Parse(value[4]), Int32.Parse(value[5]), Int32.Parse(value[6]), value[7]);
            lstEvents.Items.Add(appt);
        }
    }
}
