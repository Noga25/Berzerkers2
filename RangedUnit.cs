﻿using System;
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
            int attackRoll = HitChance.Roll(); // Roll the attack dice

            if (attackRoll > target.DefenseRating.Roll())
            {
                // Successful attack
                int damageDealt = attackRoll - Damage.Roll();
                target.HP -= damageDealt;

                Console.WriteLine($"{UnitRace} attacked {target.UnitRace} from range for {damageDealt} damage.");
            }
            else
            {
                // Missed attack
                Console.WriteLine($"{UnitRace} missed the ranged attack on {target.UnitRace}.");
            }
        }
    }
}
