//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    public abstract class RangedUnit : Unit
    {
        protected RangedUnit(Dice dmg, Dice defence) : base(dmg, defence)
        {
            //defult value 
            attackRoll = HitChance.Roll(7, 10);

            //defult value 
            damageRoll = Damage.Roll(7, 10);
        }

        //Proprtie
        int attackRoll { get; set; }
        int damageRoll { get; set; }

        // Method to ranged attacks
        public override void Attack(Unit target)
        {
            //Color red for attack
            Console.ForegroundColor = ConsoleColor.Red;

            attackRoll = HitChance.Roll(1, 10);

            if (attackRoll > target.DefenseRating.Roll(0, 10))
            {
                // Successful attack
                int damageDealt = attackRoll - Damage.Roll(0, 10); 
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
