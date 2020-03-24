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
    }
}
