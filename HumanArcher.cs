﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers2
{
    internal class HumanArcher : RangedUnit
    {
        // Properties
        public override int HP { get; set; } = 100;
        public override Race UnitRace => Race.Human;
        protected override float Range => 20;
        public override int CarryingCapacity => Random.Shared.Next(1, 20);
        protected override Dice Damage => new Dice(2, 7, -1);
        public override Dice HitChance => new Dice(2, 8, -1);
        public override Dice DefenseRating => new Dice(1, 6, 1);

        // Methods
        public override void Defend(Unit attacker)
        {
            // Implementation for defending
        }
        public override void Attack(Unit target)
        {
            base.Attack(target);

            // Add specific behavior for Orc Warrior's attack, if needed
            Console.WriteLine("Human aim");

            return;
        }
        public override void WeatherEffect(Weather weather)
        {
            weather = Weather.Sunny;

            Console.WriteLine("Your character gut burned");

            HP -= 10;

            Console.WriteLine(weather + "you lost 10 HP " + (HP));
        }
    }
}
