using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Components
{
    public class Latte : Bevarage
    {
        public Latte()
        {
            description = "Latte";
        }
        public override double cost()
        {
            return 0.9;
        }
    }
}
