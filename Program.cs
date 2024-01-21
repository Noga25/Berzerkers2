//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrcWarrior Knights = new();
            HumanKnight Wizard = new();
            List<Unit> army1 = new List<Unit> { Knights };
            List<Unit> army2 = new List<Unit> { Wizard };

            AttackUnit.Battle(army1, army2);
        }
    }
}