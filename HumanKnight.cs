using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers2
{
    public sealed class HumanKnight : RangedUnit
    {
        // Properties
        protected override int Damage => 10;
        protected override int HP => 100;
        protected override Race UnitRace => Race.Human;
        protected override float Range => 20;

        // Methods
        public override void Defend(Unit attacker)
        {
            // Implementation for defending
        }
    }
}
