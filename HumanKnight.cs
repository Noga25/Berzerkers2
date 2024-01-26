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
            Console.WriteLine("Human Knight shield active");

            Console.WriteLine("Shield: " + DefenseRating.Roll());
        }
        public override void Attack(Unit target)
        {
            base.Attack(target);

            // Add specific behavior for Orc Warrior's attack, if needed
            Console.WriteLine("Human stab");

            return;
        }
        public override void WeatherEffect(Weather weather)
        {
            weather = Weather.Sunny;

            Console.WriteLine("HumanKnight gut burned");

            HP -= 10;

            Console.WriteLine(weather + " you lost 10 HP " + HP);
        }
    }
}
