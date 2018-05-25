using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Components;

namespace WindowsFormsApp1.Conditions
{
    public class Milk : ConditionDecorator
    {
        public Milk(Bevarage bevarage) : base(bevarage)
        {
        }

        public override double cost()
        {
            return .40 + bevarage.cost();
        }

        public override string getDescription()
        {
            return bevarage.getDescription() + " | Milk";
        }
    }
}
