using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityManager
{
    class Reminder
    {
        private String message = "";
        private DateTime remindDate;
        public Reminder(String message, DateTime remindDate)
        {
            this.message = message;
            this.remindDate = remindDate;
        }
        public override String ToString()
        {
            return message;
        }
        

    }
}
