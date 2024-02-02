//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

using System.Collections.Generic;

namespace Berzerkers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBattleAndUnits();
        }

        public static void PrintBattleAndUnits()
        {
            //Units
            OrcWarrior Warrior = new();
            ElfWizard Wizard = new();
            HumanKnight Knights = new();
            HumanArcher Archer = new();

            //Units lists
            IRandomProvider randomProvider = new Bag (new List<int> { 0, 1, 2, 3 });
            //Units lists
            List<Unit> Units = new List<Unit> { Knights, Archer, Wizard, Warrior };

            List<Unit> Army1 = new List<Unit> {};
            List<Unit> Army2 = new List<Unit> {};

            Shuffle(Units);

            for (int i = 0; i < 4; i++)
            {
                int UnitNum = randomProvider.Roll(0, 4);
                Unit unit = Units[UnitNum];

                // Distribute units between Army1 and Army2
                if (i % 2 == 0)
                {
                    Army1.Add(unit);
                }
                else
                {
                    Army2.Add(unit);
                }
            }

            //List<Unit> Army1 = new List<Unit> { Units[0], Units[1] };
            //List<Unit> Army2 = new List<Unit> { Units[2], Units[3] };

            Console.WriteLine("Your army is: " + Army1[0] + " " + Army1[1]);

            Console.WriteLine("Enemy army is: " + Army2[0] + " " + Army2[1]);

            Console.WriteLine("-----------------------");

            Console.WriteLine("Damage/Attack Status - red", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("Defend - yellow", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine("Winner - green", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("Resources/Names Of Attacks - white", Console.ForegroundColor = ConsoleColor.White);

            Console.WriteLine("-----------------------");

            AttackUnit.Battle(Army1, Army2);
        }

        public static void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int units = list.Count;
            while (units > 1)
            {
                units--;
                int k = rng.Next(units + 1);
                T value = list[k];
                list[k] = list[units];
                list[units] = value;
            }
        }
    }
}