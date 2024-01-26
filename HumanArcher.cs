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

        // Methods
        public override void Defend(Unit attacker)
        {
            Console.WriteLine("Human Archer shield active");

            Console.WriteLine("Shield: " + DefenseRating.Roll());
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

            Console.WriteLine(weather + " you lost 10 HP " + HP);
        }
    }
}

