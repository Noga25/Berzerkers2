//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

using static Berzerkers2.Interface;

namespace Berzerkers2
{
    internal class HumanArcher : RangedUnit
    {
        protected virtual IRandomProvider DamageWeather { get; }

        IRandomProvider bag = new Bag(1, 2);

        public HumanArcher(Dice dmg, Dice defence) : base(dmg, defence)
        {
            //The damage as a result of extreme weather
            dmg = new Dice(2, 7, -1);
            DamageWeather = dmg;
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

            Console.WriteLine("It cost coins " + bag.Roll(1, 11));

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

            int Damage = DamageWeather.Roll(0, 10);

            HP -= Damage;

            Console.WriteLine("The weather is " + weather + " HumanArcher lost "  + Damage + " HP " + HP, Console.ForegroundColor == ConsoleColor.Yellow);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

