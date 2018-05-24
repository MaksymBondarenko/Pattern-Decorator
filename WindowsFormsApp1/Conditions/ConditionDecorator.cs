using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Components;

namespace WindowsFormsApp1.Conditions
{
    public abstract class ConditionDecorator : Bevarage
    {

        protected Bevarage bevarage = null;
        public ConditionDecorator(Bevarage bevarage)
        {
            this.bevarage = bevarage;
        }

    }
}
