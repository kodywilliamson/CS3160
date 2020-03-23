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

        public class Event
        {
            private DateTime startTime { get; }
            private DateTime endTime { get; }
            private string eventTitle { get; }
            public Event(int Year, int Month, int Day, int startHour, int startMin, int endHour, int endMin, string Title)
            {
                startTime = new DateTime(Year, Month, Day, startHour, startMin, 0);
                endTime = new DateTime(Year, Month, Day, endHour, endMin, 0);
                eventTitle = Title;
            }
        }
    }
}
