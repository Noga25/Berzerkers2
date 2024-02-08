//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

using static Berzerkers2.Interface;

namespace Berzerkers2
{
    public abstract class RangedUnit : Unit
    {
        protected virtual IRandomProvider AttackRoll { get; }
        protected virtual IRandomProvider DamageRoll { get; }
        protected RangedUnit(Dice attackRoll, Dice damageRoll) : base(attackRoll, damageRoll)
        {
            //defult value 
            attackRoll = new Dice(2, 8, -1);
            AttackRoll = attackRoll;

            //defult value 
            damageRoll = new Dice(2, 7, -1);
            DamageRoll = damageRoll;
        }

        // Method to ranged attacks
        public override void Attack(Unit target)
        {
            //Color red for attack
            Console.ForegroundColor = ConsoleColor.Red;

            if (AttackRoll.Roll(0, 10) > target.DefenseRating.Roll(0, 10))
            {
                // Successful attack
                int damageDealt = AttackRoll.Roll(6, 10) - DamageRoll.Roll(0, 10); 
                target.HP -= damageDealt;
            }
            else
            {
                // Missed attack
                Console.WriteLine($"{UnitRace} missed the ranged attack.");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
