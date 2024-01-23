//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    public abstract class AttackUnit : Unit
    {
        private static void ApplyWeatherEffect(List<Unit> army, Weather weatherCondition)
        {
            foreach (var unit in army)
            {
                unit.WeatherEffect(weatherCondition);
            }
        }

        public static void Battle(List<Unit> army1, List<Unit> army2) 
        {
            Random random = new Random();
            int steps = 0;

            while (army1.Count > 0 && army2.Count > 0)
            {
                Unit attacker1 = army1[random.Next(army1.Count)];
                Unit attacker2 = army2[random.Next(army2.Count)];

                // Simulate the attack and defend
                attacker1.Attack(attacker2);
                attacker2.Attack(attacker1);


                // Check for weather condition
                if (random.NextDouble() < 0.1 && steps < 1) 
                {
                    Weather weatherCondition = (Weather)random.Next(Enum.GetValues(typeof(Weather)).Length);
                    ApplyWeatherEffect(army1, weatherCondition);
                    ApplyWeatherEffect(army2, weatherCondition);
                    steps += 1;
                }

                // Remove dead units
                army1.RemoveAll(unit => unit.HP <= 0);
                army2.RemoveAll(unit => unit.HP <= 0);
            }

            // Determine the winner
            List<Unit> winningArmy = (army1.Count > 0) ? army1 : army2;

            // Calculate the number of resources stolen by the winning actor
            int totalResourcesStolen = winningArmy.Sum(unit => unit.CarryingCapacity) * steps;

            Console.WriteLine($"The winner is the {winningArmy[0].UnitRace} race!");
            Console.WriteLine($"Resources stolen: {totalResourcesStolen}");
        }
    }
}
