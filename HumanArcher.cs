//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    internal class HumanArcher : RangedUnit
    {
        public HumanArcher(Dice dmg, Dice defence) : base(dmg, defence)
        {
        }

        // Properties
        public override Race UnitRace => Race.Human;

        // Methods
        public override void Defend(Unit attacker)
        {
            //Color yellwo for defend
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Human Archer shield active");

            Console.WriteLine("Shield: " + DefenseRating.Roll(0, 10));

            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Attack(Unit target)
        {
            base.Attack(target);

            Console.WriteLine("Human aim");

            return;
        }
        public override void WeatherEffect(Weather weather)
        {
            //Color blue for weather
            Console.ForegroundColor = ConsoleColor.Blue;

            weather = Weather.Sunny;

            Console.WriteLine("HumanArcher character gut burned");

            HP -= 10;

            Console.WriteLine("The weather is " + weather + " HumanArcher lost 10 HP " + HP, Console.ForegroundColor == ConsoleColor.Yellow);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

