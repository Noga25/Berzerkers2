//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    public sealed class ElfWizard : RangedUnit
    {
        public ElfWizard(Dice randomProvider) : base(randomProvider)
        {
        }

        // Properties
        public override Race UnitRace => Race.Elf;

        // Methods
        public override void Defend(Unit attacker)
        {
            //Color yellwo for defend
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Elf Wizard shield active");

            Console.WriteLine("Shield: " + DefenseRating.Roll(0, 10));

            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Attack(Unit target)
        {
            base.Attack(target);

            Console.WriteLine("Elf Activate attack magic");

            return;
        }

        public override void WeatherEffect(Weather weather)
        {
            //Color blue for weather
            Console.ForegroundColor = ConsoleColor.Blue;

            weather = Weather.Sunny;

            Console.WriteLine("ElfWizard gut burned");

            HP -= 10;

            Console.WriteLine("The weather is " + weather + " ElfWizard lost 10 HP " + HP);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
