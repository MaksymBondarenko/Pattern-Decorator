using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Components
{
    public class Americano : Bevarage
    {
        public Americano()
        {
            description = "Americano";
        }
        public override double cost()
        {
            return 0.7;
        }
    }
}
