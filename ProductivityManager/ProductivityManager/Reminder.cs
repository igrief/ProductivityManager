﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityManager
{
    [Serializable]
    class Reminder
    {
        public String message { get; set; }
        public DateTime remindDate { get; set; }
        public Reminder(String message, DateTime remindDate)
        {
            this.message = message;
            this.remindDate = remindDate;
        }
        public override String ToString()
        {
            return message + " " + remindDate.ToString();
        }
        

    }
}
