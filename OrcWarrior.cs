//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    public sealed class OrcWarrior : RangedUnit
    {
        // Properties
        public override Race UnitRace => Race.Orc;

        // Methods
        public override void Defend(Unit Attacker)
        {
            Console.WriteLine("Orc Warrior active shield");

            Console.WriteLine("Shield: " + DefenseRating.Roll());
        }
        public override void Attack(Unit target)
        {
            base.Attack(target);

            Console.WriteLine("Orc warrior slice");

            return;
        }
        public override void WeatherEffect(Weather weather)
        {
            weather = Weather.Rainy;

            Console.WriteLine("OrcWarrior has slipped");

            HP -= 10;

            Console.WriteLine("The weather is " + weather + " OrcWarrior lost 10 HP " + HP);
        }
    }
}
