﻿//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

using static Berzerkers2.Interface;

namespace Berzerkers2
{
    public class ElfWizard : RangedUnit
    {
        protected virtual IRandomProvider DamageWeather { get; }
        public ElfWizard(Dice dmg, Dice defence) : base(dmg, defence)
        {
            //The damage as a result of extreme weather
            dmg = new Dice(2, 7, -1);
            DamageWeather = dmg;
        }

        // Properties
        public override Race UnitRace => Race.Elf;

        // Methods
        public override void Defend(Unit attacker)
        {
            //Color yellwo for defend
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Elf Wizard shield active");

            Console.WriteLine("Shield: " + DefenseRating.Roll(0, 10));

            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Attack(Unit target)
        {
            base.Attack(target);

            Console.WriteLine("Elf Activate attack magic");

            return;
        }

        public override void WeatherEffect(Weather weather)
        {
            //Color blue for weather
            Console.ForegroundColor = ConsoleColor.Blue;

            weather = Weather.Sunny;

            Console.WriteLine("ElfWizard gut burned");

            int Damage = DamageWeather.Roll(0, 10);

            HP -= Damage;

            Console.WriteLine("The weather is " + weather + " ElfWizard lost " + Damage + " HP " + HP);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
