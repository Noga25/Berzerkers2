//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    public abstract class RangedUnit : Unit
    {
        protected RangedUnit(Dice dmg, Dice defence) : base(dmg, defence)
        {
        }

        // Method to ranged attacks
        public override void Attack(Unit target)
        {
            //Color red for attack
            Console.ForegroundColor = ConsoleColor.Red;

            int attackRoll = HitChance.Roll(0, 10);

            if (attackRoll > target.DefenseRating.Roll(0, 10))
            {
                // Successful attack
                int damageDealt = attackRoll - Damage.Roll(0, 10);
                target.HP -= damageDealt;
            }
            else
            {
                // Missed attack
                Console.WriteLine($"{UnitRace} missed the ranged attack on {target.UnitRace}.");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
