using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityManager
{
    [Serializable]
    class Todo
    {
        private String name = "";
        public Todo(String name)
        {
            this.name = name;
        }
        public override String ToString()
        {
            return name;
        }
    }
}
