//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Units
            OrcWarrior Warrior = new();
            ElfWizard Wizard = new();
            HumanKnight Knights = new();
            HumanArcher Archer = new();

            //Units list
            List<Unit> army1 = new List<Unit> { Knights, Archer };
            List<Unit> army2 = new List<Unit> { Warrior, Wizard };

            AttackUnit.Battle(army1, army2);
        }
    }
}