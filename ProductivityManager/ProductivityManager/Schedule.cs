using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityManager
{
    enum Recur
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Annually
    }
    class Schedule
    {
    }

    class Event
    {
        public string description { get; set; }
        public DateTime eventDate { get; set; }
        public Recur recurrence { get; set; } = Recur.None;
        
        public Event(string description, DateTime eventDate, Recur recurrence)
        {
            this.description = description;
            this.eventDate = eventDate;
            this.recurrence = recurrence;
        }

        public override string ToString()
        {
            return description + " " + eventDate.ToShortDateString() + " " + recurrence.ToString();
        }

    }
}
