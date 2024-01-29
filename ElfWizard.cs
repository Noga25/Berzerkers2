//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    public sealed class ElfWizard : RangedUnit
    {
        // Properties
        public override Race UnitRace => Race.Elf;

        // Methods
        public override void Defend(Unit attacker)
        {
            Console.WriteLine("Elf Wizard shield active");

            Console.WriteLine("Shield: " + DefenseRating.Roll());
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

            Console.WriteLine("The weather is " + weather + " ElfWizard lost 10 HP " + HP);
        }
    }
}
