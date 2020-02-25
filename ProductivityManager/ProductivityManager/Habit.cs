using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityManager
{
    class Habit
    {
        private String name = "";
        private int consecutiveDays = 0;

        public bool doneToday { get; set; } = false;

        public Habit(String name)
        {
            this.name = name;
        }
        public override String ToString()
        {
            return name;
        }
    }
}
