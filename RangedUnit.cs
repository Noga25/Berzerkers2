using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers2
{
    public abstract class RangedUnit : Unit
    {
        //Propetie who set the range
        protected abstract float Range { get; }

        // Method to ranged attacks
        public override void Attack(Unit target)
        {
            // Implementation for ranged attack
        }
    }
}
