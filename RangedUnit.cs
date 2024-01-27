//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    public abstract class RangedUnit : Unit
    {
        // Method to ranged attacks
        public override void Attack(Unit target)
        {
            int attackRoll = HitChance.Roll();

            if (attackRoll > target.DefenseRating.Roll())
            {
                // Successful attack
                int damageDealt = attackRoll - Damage.Roll();
                target.HP -= damageDealt;
            }
            else
            {
                // Missed attack
                Console.WriteLine($"{UnitRace} missed the ranged attack on {target.UnitRace}.");
            }
        }
    }
}
