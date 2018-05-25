using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Components;

namespace WindowsFormsApp1.Conditions
{
    public class Whip: ConditionDecorator
    {
        public Whip(Bevarage bevarage) : base(bevarage)
        {
        }

        public override double cost()
        {
            return .55 + bevarage.cost();
        }

        public override string getDescription()
        {
            return bevarage.getDescription() + " | Whip";
        }
    }
}
