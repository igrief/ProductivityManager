using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityManager
{
    [Serializable]
    class Habit
    {
        private String name = "";
        public DateTime lastDone { get; set; } = DateTime.MinValue;

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
