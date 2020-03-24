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
                if (Title == "")
                    throw new System.ArgumentException("Event Title cannot be empty.");
                if (startHour < endHour)
                {
                    if (startMin > endMin)
                        throw new System.ArgumentException("Event ends before it starts.");
                }
                else
                    throw new System.ArgumentException("Event ends before it starts.");

                startTime = new DateTime(Year, Month, Day, startHour, startMin, 0);
                endTime = new DateTime(Year, Month, Day, endHour, endMin, 0);
                eventTitle = Title;
            }
            public override string ToString()
            {
                return ($"{startTime.Year}-{startTime.Month}-{startTime.Day} {startTime.Hour}:{startTime.Minute}");
            }
            public override bool Equals(object obj)
            {
                var other = obj as Event;

                if (other == null)
                    return false;
                if (other.startTime != this.startTime)
                    return false;
                else if (other.endTime != this.endTime)
                    return false;
                else if (other.eventTitle != this.eventTitle)
                    return false;
                return true;

            }
            public override int GetHashCode()
            {
                int hashCode = 12345;
                int holder = 0;
                holder = startTime.Year + startTime.Month + startTime.Day;
                return holder * hashCode;
            }
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
            txtDetail.Text = lstEvents.SelectedItem.
        }
    }
}
