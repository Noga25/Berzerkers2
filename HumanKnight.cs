//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    public sealed class HumanKnight : RangedUnit
    {
        // Properties
        public override Race UnitRace => Race.Human;

        // Methods
        public override void Defend(Unit attacker)
        {
            //Color yellwo for defend
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Human Knight shield active");

            Console.WriteLine("Shield: " + DefenseRating.Roll());

            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Attack(Unit target)
        {
            base.Attack(target);

            Console.WriteLine("Human stab");

            return;
        }
        public override void WeatherEffect(Weather weather)
        {
            //Color blue for weather
            Console.ForegroundColor = ConsoleColor.Blue;

            weather = Weather.Sunny;

            Console.WriteLine("HumanKnight gut burned");

            HP -= 10;

            Console.WriteLine("The weather is " + weather + " HumanKnight lost 10 HP " + HP);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
