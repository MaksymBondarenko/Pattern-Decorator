using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Components
{
    public class Capuccino : Bevarage
    {
        public Capuccino()
        {
            description = "Capuccino";
        }
        public override double cost()
        {
            return 0.8;
        }
    }
}
