using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers2
{
    public sealed class OrcWarrior : RangedUnit
    {
        // Properties
        public override int HP { get; set; } = 100;
        public override Race UnitRace => Race.Orc;
        protected override float Range => 20;
        public override int CarryingCapacity => 20;
        protected override Dice Damage => new Dice(2, 7, -1);
        public override Dice HitChance => new Dice(2, 8, -1);
        public override Dice DefenseRating => new Dice(1, 6, 1);

        // Methods
        public override void Defend(Unit Attacker)
        {
            // Implementation for defending
        }
        public override void Attack(Unit target)
        {
            base.Attack(target);

            // Add specific behavior for Orc Warrior's attack, if needed
            Console.WriteLine("Orc Warrior Slice.");

            return;
        }
        public override void WeatherEffect(Weather weather)
        {
            weather = Weather.Rainy;

            Console.WriteLine("Your character has slipped");

            HP -= 10;

            Console.WriteLine(weather + "you lost 10 HP " + (HP));
        }
    }
}
