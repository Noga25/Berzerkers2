using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers2
{
    internal class HumanArcher : RangedUnit
    {
        // Properties
        public override Race UnitRace => Race.Human;
        public override int CarryingCapacity => Random.Shared.Next(1, 20);
        protected override Dice Damage => new Dice(2, 7, -1);
        public override Dice HitChance => new Dice(2, 8, -1);
        public override Dice DefenseRating => new Dice(1, 6, 1);

        // Methods
        public override void Defend(Unit attacker)
        {
            Console.WriteLine("Human Archer shield active");

            Console.WriteLine("Shield: " + DefenseRating.ToString());
        }
        public override void Attack(Unit target)
        {
            base.Attack(target);

            Console.WriteLine("Human aim");

            return;
        }
        public override void WeatherEffect(Weather weather)
        {
            weather = Weather.Sunny;

            Console.WriteLine("HumanArcher character gut burned");

            HP -= 10;

            Console.WriteLine(weather + "you lost 10 HP " + (HP));
        }
    }
}

