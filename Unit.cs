using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers2
{
    public struct Dice
    {
        public uint Scalar;
        public uint BaseDie;
        public int Modifier;

        public Dice(uint scalar, uint baseDie, int modifier)
        {
            Scalar = scalar;
            BaseDie = baseDie;
            Modifier = modifier;
        }

        public int Roll()
        {
            Random random = new Random();
            int result = 0;

            for (int i = 0; i < Scalar; i++)
            {
                result += random.Next(1, (int)BaseDie + 1);
            }

            return result + Modifier;
        }

        public override string ToString()
        {
            return $"{Scalar}d{BaseDie}";
        }

        public override int GetHashCode()
        {
            // A simple hash combining the values
            int hash = 17;
            hash = hash * 23 + Scalar.GetHashCode();
            hash = hash * 23 + BaseDie.GetHashCode();
            hash = hash * 23 + Modifier.GetHashCode();
            return hash;
        }
    }

    // Enum of the race
    public enum Race
    {
        Human,
        Orc,
        Elf
    }

    // Enum of the Weather
    public enum Weather
    {
        Rainy,
        Stormy,
        Sunny
    }

    public abstract class Unit
    {
        // Properties
        protected abstract int Damage { get; }
        protected abstract int HP { get; }
        protected abstract Race UnitRace { get; }
        public int CarryingCapacity { get; set; }
        public Dice HitChance { get; set; }
        public Dice DefenseRating { get; set; }
        public Weather WeatherEffect { get; set; }


        // Methods
        public abstract void Attack(Unit target);
        public abstract void Defend(Unit attacker);
    }
}
