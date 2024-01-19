using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers2
{
    public sealed class OrcWarrior : AttackUnit
    {
        // Properties
        protected override int Damage => 15;
        protected override int HP => 120;
        protected override Race UnitRace => Race.Orc;

        // Methods
        public override void Defend(Unit attacker)
        {
            // Implementation for defending
        }
    }
}
