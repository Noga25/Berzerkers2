//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    public sealed class ElfWizard : RangedUnit
    {
        // Properties
        public override Race UnitRace => Race.Elf;
        public override int CarryingCapacity => Random.Shared.Next(1, 20);
        protected override Dice Damage => new Dice(2, 7, -1);
        public override Dice HitChance => new Dice(2, 8, -1);
        public override Dice DefenseRating => new Dice(1, 6, 1);

        // Methods
        public override void Defend(Unit attacker)
        {
            Console.WriteLine("Elf Wizard shield active");

            Console.WriteLine("Shield: " + DefenseRating.ToString());
        }
        public override void Attack(Unit target)
        {
            base.Attack(target);

            Console.WriteLine("Elf Activate attack magic");

            return;
        }
        public override void WeatherEffect(Weather weather)
        {

            weather = Weather.Sunny;

            Console.WriteLine("ElfWizard gut burned");

            HP -= 10;

            Console.WriteLine(weather + "you lost 10 HP " + (HP));
        }
    }
}
