using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Components
{
    public abstract class Bevarage
    {

        public string description = "Unknown Bevarage";

        public abstract double cost();
        public virtual string getDescription()
        {
            return description;
        }
    }
}
