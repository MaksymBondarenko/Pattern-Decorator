using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Components
{
    public class Capuchino : Bevarage
    {
        public Capuchino()
        {
            description = "Capuchino";
        }
        public override double cost()
        {
            return 0.8;
        }
    }
}
