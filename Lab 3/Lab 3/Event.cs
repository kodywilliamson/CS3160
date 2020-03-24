using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Event
    {
        public DateTime startTime { get; private set; }
        public DateTime endTime { get; private set; }
        public string eventTitle { get; private set; }
        public Event(int Year, int Month, int Day, int startHour, int startMin, int endHour, int endMin, string Title)
        {
            if (Title == "")
                throw new System.ArgumentException("Event Title cannot be empty.");
            if (startHour < endHour)
            {
                if ((startMin > endMin) && (startHour == endHour))
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
}
