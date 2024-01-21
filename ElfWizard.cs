using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers2
{
    public sealed class ElfWizard : RangedUnit
    {
        // Properties
        protected override float Range => 40;
        public override int HP { get; set; } = 100;
        public override Race UnitRace => Race.Elf;
        public override int CarryingCapacity => 20;
        protected override Dice Damage => new Dice(2, 7, -1);
        public override Dice HitChance => new Dice(2, 8, -1);
        public override Dice DefenseRating => new Dice(1, 6, 1);

        // Methods
        public override void Defend(Unit attacker)
        {
            //Implementation for defending
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
